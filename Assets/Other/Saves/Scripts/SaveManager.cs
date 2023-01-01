using UnityEngine;
namespace IUnity
{
    public static class SaveManager
    {
        public static bool useEncryption;

        public static void Save<T>(string key, T data)
        {
            string jsonDataString = JsonUtility.ToJson(data, true);
            string encryptedJsonData = useEncryption ? jsonDataString.Encrypt() : jsonDataString;

            PlayerPrefs.SetString(key, encryptedJsonData);
        }

        public static T Load<T>(string key) where T : new()
        {
            if (PlayerPrefs.HasKey(key))
            {
                string loadedString = PlayerPrefs.GetString(key);
                string decryptetJsonData = useEncryption? loadedString.Decrypt() : loadedString;

                return JsonUtility.FromJson<T>(decryptetJsonData);
            }
            else
            {
                return new T();
            }
        }
    }
}