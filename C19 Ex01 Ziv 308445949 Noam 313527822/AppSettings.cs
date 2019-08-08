﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace C19_Ex01_Ziv_308445949_Noam_313527822
{
    class AppSettings
    {
        private const string k_SettingsFilePath = "AppSettings.xml";
        public const int k_DefaultMainFormWidth = 1200;
        public const int k_DefaultMainFormHeight = 800;
        private static readonly Size sr_DefaultFormSize = new Size(k_DefaultMainFormHeight, k_DefaultMainFormHeight);

        public Point LastWindowLocation { get; set; }

        public Size LastWindowsSize { get; set; }

        public FormStartPosition LastFormStartPosition { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        { 
            SetDefaultSettings();
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;
            Stream stream = null;

            try
            {
                stream = new FileStream(k_SettingsFilePath, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));

                appSettings = serializer.Deserialize(stream) as AppSettings;
            }
            catch
            {
                appSettings = new AppSettings();
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                }
            }

            return appSettings;
        }

        public void SaveToFile()
        {
            if (!File.Exists(k_SettingsFilePath))
            {
                File.Create(k_SettingsFilePath).Close();
            }

            using (Stream stream = new FileStream(k_SettingsFilePath, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());

                serializer.Serialize(stream, this);
            }
        }

        public void SetDefaultSettings()
        {
            LastWindowsSize = sr_DefaultFormSize;
            LastFormStartPosition = FormStartPosition.CenterScreen;
            LastWindowLocation = new Point();
            LastAccessToken = null;
            RememberUser = false;
        }
    }
}
