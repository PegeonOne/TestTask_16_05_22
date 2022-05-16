using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveID(Save _saves)
    {
        string path = Application.persistentDataPath + "/ID.data";
        FileStream strem = new FileStream(path, FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        
        formatter.Serialize(strem, _saves);
        strem.Close();
    }
    public static Save LoadID()
    {
        string path = Application.persistentDataPath + "/ID.data";
        if (File.Exists(path))
        {
            
            FileStream strem = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Save save = formatter.Deserialize(strem) as Save;
            strem.Close();
            return save;
        }
        return null;
    }
}
