﻿namespace BanGongPingTai.Properties {

	using System.Data.SqlClient;
    
    // 通过此类可以处理设置类的特定事件:
    //  在更改某个设置的值之前将引发 SettingChanging 事件。
    //  在更改某个设置的值之后将引发 PropertyChanged 事件。
    //  在加载设置值之后将引发 SettingsLoaded 事件。
    //  在保存设置值之前将引发 SettingsSaving 事件。
    internal sealed partial class Settings {
        
        public Settings() {
            // // 若要为保存和更改设置添加事件处理程序，请取消注释下列行:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
			//
			this.SettingsLoaded += this.SettingsLoadedEventHandler;
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // 在此处添加用于处理 SettingChangingEvent 事件的代码。
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // 在此处添加用于处理 SettingsSaving 事件的代码。
        }


		private void SettingsLoadedEventHandler(object sender, System.Configuration.SettingsLoadedEventArgs e)
		{
			// Add code to handle the SettingsSaving event here.
			SqlConnectionStringBuilder ConnSb = new SqlConnectionStringBuilder();
			ConnSb.ConnectionString = this["ChildrenPalaceConnectionString"].ToString();
			ConnSb.Password = "woaicry";

			this["ChildrenPalaceConnectionString"] = ConnSb.ConnectionString;
		}
    }
}
