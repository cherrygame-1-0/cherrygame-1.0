using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

class Data
{
    public int coin;
    public int star;
    public int stage1_star;
}

public class DataBase : MonoBehaviour
{
    Data player = new Data() { coin = 0, star = 0, stage1_star = 0 };
    string path;

    private void Awake()
    {
        path = Application.persistentDataPath;
    }
    private void Start()
    {
        string data = JsonUtility.ToJson(player);
        print(data);
        File.WriteAllText(path, data);
    }
}
