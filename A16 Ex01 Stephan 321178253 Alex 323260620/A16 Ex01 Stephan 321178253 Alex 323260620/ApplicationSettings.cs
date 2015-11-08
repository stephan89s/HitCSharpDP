using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    class ApplicationSettings
    {
        private static readonly string sr_FileName;
        private static ApplicationSettings ApplicationSettingsInstance;
        public bool AutoLogin { get; set; }
        public string AccessToken { get; set; }
        static ApplicationSettings()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }
        private ApplicationSettings()
        {
        }

        public static ApplicationSettings Instance
        {
            get
            {
                if (ApplicationSettingsInstance == null)
                {
                    ApplicationSettingsInstance = ApplicationSettings.FromFileOrDefault();
                }

                return ApplicationSettingsInstance;
            }
        }









        public void Save()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                serializer.Serialize(stream, this);
            }
        }








        public static ApplicationSettings FromFileOrDefault()
        {
            ApplicationSettings loadedSettings = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    loadedSettings = (ApplicationSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                
                loadedSettings = new ApplicationSettings()
                {
                    AutoLogin = false,
                    
                };
            }

            return loadedSettings;
        }
    }
}
