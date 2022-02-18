using System.IO;
using UnityEngine;

public static class SaveLoad
{
    private static string Path; 
    
    public static void Save(SaveData data)
    {
        var json = JsonUtility.ToJson(data);
        File.WriteAllText(GetPath(), json);
        Debug.Log(Path);
    }

    public static SaveData Load()
    {
        if (File.Exists(GetPath()) == false)
            return new SaveData();
        var json = File.ReadAllText(GetPath());
        var data = JsonUtility.FromJson<SaveData>(json);
        
        return data;
    }

    private static string GetPath()
    {
        return Path ??= Application.persistentDataPath + "Save.data";
    }
}