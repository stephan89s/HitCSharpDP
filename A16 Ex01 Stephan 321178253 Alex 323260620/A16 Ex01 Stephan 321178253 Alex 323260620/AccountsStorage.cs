using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    
    public class AccountsStorage
    {
        private static readonly string sr_FileName;
        private static AccountsStorage s_AccountsStorageInstance;
        public List<UserConfiguration> StorageList { get; set; }
        public event Action<UserConfiguration> UserConfigurationsAddedToStorage;
        public event Action<UserConfiguration> UserConfigurationsRemovedFromStorage;

        private AccountsStorage()
        {
            StorageList = new List<UserConfiguration>();          
        }
        
        static AccountsStorage()
        {
            sr_FileName = "AccountsSettings.xml";
        }

        public static AccountsStorage Instance
        {
            get
            {
                if (s_AccountsStorageInstance == null)
                {
                    s_AccountsStorageInstance = new AccountsStorage();
                }

                return s_AccountsStorageInstance;
            }
        }
        public void AddToStorage(string i_UniqueName, string i_AccessToken)
        {
            UserConfiguration UserConfigurationToStore = new UserConfiguration(i_UniqueName, i_AccessToken);
            if (!StorageList.Any(name=> name.uniqueName==i_UniqueName))
            {
                StorageList.Add(UserConfigurationToStore);
                if (UserConfigurationsAddedToStorage != null)
                {
                    UserConfigurationsAddedToStorage(UserConfigurationToStore);
                }
            }
        }

        public void RemoveFromStorage(AccountsStorage.UserConfiguration i_UserConfigToRemove)
        {
            StorageList.Remove(i_UserConfigToRemove);
            UserConfigurationsRemovedFromStorage(i_UserConfigToRemove);
        }


        public void SaveToFile()
        {
            
                using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<UserConfiguration>));
                    serializer.Serialize(stream, StorageList);
                }
            
        }


        public bool isStorageEmpty
        {
            get
            {
                return StorageList.Count == 0;
            }
            
        }
        public void LoadFromFile()
        {
            

            if (File.Exists(sr_FileName))
            {
                List<UserConfiguration> loadedFromFileList = null;
                using (FileStream stream = new FileStream(sr_FileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<UserConfiguration>));
                    loadedFromFileList = (List<UserConfiguration>)serializer.Deserialize(stream);
                }
            StorageList = loadedFromFileList;
            }
        }


        public class UserConfiguration 
        {
            public string AccessToken { get; set; }
            public string uniqueName { get; set; }

            public UserConfiguration (string i_UserName, string i_AccessToken)
            {
                uniqueName = i_UserName;
                AccessToken = i_AccessToken;
            }
            public UserConfiguration()
            { 
            }
            public override string ToString()
            {
                return uniqueName;
            }
        }
    }
}
