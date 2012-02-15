using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Runtime.InteropServices;

namespace BanGongPingTai
{
    public partial class CardConnectForm : Form
    {
        [DllImport("dcrf32.dll")]
        public static extern int dc_init(Int16 port, long baud);  //初试化
        [DllImport("dcrf32.dll")]
        public static extern int dc_exit(int icdev);
        [DllImport("dcrf32.dll")]
        public static extern int dc_reset(int icdev, uint sec);
        [DllImport("dcrf32.dll")]
        public static extern int dc_request(int icdev, char _Mode, ref uint TagType);
        [DllImport("dcrf32.dll")]
        public static extern int dc_card(int icdev, char _Mode, ref ulong Snr);
        [DllImport("dcrf32.dll")]
        public static extern int dc_halt(int icdev);
        [DllImport("dcrf32.dll")]
        public static extern int dc_anticoll(int icdev, char _Bcnt, ref ulong IcCardNo);
        [DllImport("dcrf32.dll")]
        public static extern int dc_beep(int icdev, uint _Msec);
        [DllImport("dcrf32.dll")]
        public static extern int dc_authentication(int icdev, int _Mode, int _SecNr);

        [DllImport("dcrf32.dll")]
        public static extern int dc_load_key(int icdev, int mode, int secnr, [In] byte[] nkey);  //密码装载到读写模块中
        [DllImport("dcrf32.dll")]
        public static extern int dc_load_key_hex(int icdev, int mode, int secnr, string nkey);  //密码装载到读写模块中

        [DllImport("dcrf32.dll")]
        public static extern int dc_write(int icdev, int adr, [In] byte[] sdata);  //向卡中写入数据
        [DllImport("dcrf32.dll")]
        public static extern int dc_write_hex(int icdev, int adr, [In] byte[] sdata);  //向卡中写入数据(转换为16进制)

        [DllImport("dcrf32.dll")]
        public static extern int dc_read(int icdev, int adr, [Out] byte[] sdata);  //从卡中读数据
        [DllImport("dcrf32.dll")]
        public static extern int dc_read_hex(int icdev, int adr, [Out] byte[] sdata);  //从卡中读数据(转换为16进制)
        [DllImport("dcrf32.dll")]
        public static extern int a_hex(string oldValue, ref string newValue, Int16 len);  //普通字符转换成十六进制字符
        [DllImport("dcrf32.dll")]
        public static extern void hex_a(ref string oldValue, ref string newValue, int len);  //十六进制字符转换成普通字符

        public string cardNo = "";

        public CardConnectForm()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cardNo = txtCardNo.Text;
                this.Close();
            }
        }

        private void CardConnectForm_Shown(object sender, EventArgs e)
        {
            txtCardNo.Text = "";
            txtCardNo.Focus();
        }

        ulong rawCardNo;
        private void ReadCard()
        {
            while (true)
            {
                char tt = (char)0;
                uint ss = 0;

                ulong icCardNo = 0;
                dc_reset(_icdev, ss);
                dc_card(_icdev, tt, ref icCardNo);
                if (icCardNo != 0)
                {
                    //蜂鸣
                    dc_beep(_icdev, 10);

                    Monitor.Enter(this);//锁定，保持同步
                    rawCardNo = icCardNo;
                    Monitor.Exit(this);//取消锁定
                    break;
                }

                Thread.Sleep(100);
            }
        }

        private void GetCardNo()
        {
            while (true)
            {
                Monitor.Enter(this);//锁定，保持同步
                if (rawCardNo > 0)
                {
                    txtCardNo.Text = rawCardNo.ToString();
                    Monitor.Exit(this);//取消锁定

                    Thread.Sleep(200);
                    cardNo = txtCardNo.Text;
                    this.Close();
                    
                    return;
                }
                Monitor.Exit(this);//取消锁定
                Thread.Sleep(100);
            }
        }

        private Thread threadReadCardno = null;
        private Thread threadGetCardNo = null;
        private int _icdev = -1;

        private void CardConnectForm_Load(object sender, EventArgs e)
        {
            // 初始化设备
            _icdev = dc_init(100, 115200);

            if (_icdev > 0)
            {
                threadReadCardno = new Thread(ReadCard);
                threadGetCardNo = new Thread(GetCardNo);
                threadReadCardno.Start();
                threadGetCardNo.Start();
            }
        }

        private void CardConnectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(threadReadCardno != null)
                threadReadCardno.Abort();
            if(threadGetCardNo != null)
                threadGetCardNo.Abort();
            if (_icdev > 0)
            {
                dc_exit(_icdev);
            }
        }

    }
}
