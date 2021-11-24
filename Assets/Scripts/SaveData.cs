using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveData
{
    public static void SaveGameData()
    {
        //string contents our save path + creates json file
        string path = Application.persistentDataPath + "/savedata.json";

        //create save data
        

        if (!File.Exists(path))
        {
            File.Create(path);
        }

        StreamWriter writer = new StreamWriter(path);
        writer.Write(saveFile);
        writer.Close();
    }
    

}
