using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Common
{
    public class Algorithm
    {
        public static int GetTablePositionFromDataGridViewRow(DataGridViewRow row, DataRowCollection rows)
        {
            DataRowView drv = row.DataBoundItem as DataRowView;
            return rows.IndexOf(drv.Row);
        }
    }
}
