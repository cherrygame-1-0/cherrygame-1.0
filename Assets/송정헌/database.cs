using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerData
{
    public int level;
    public int coin;

}
public class database : MonoBehaviour
{
    string path;
    string filename = "save";

    public static database instance;

    private void Awake()
    {
        path = Application.persistentDataPath + "/";
    }
    PlayerData nowPlayer = new PlayerData();


    // Start is called before the first frame update
    void Start()
    {
        nowPlayer.level = 5;
        nowPlayer.coin = 0;
        print(path);
    }

    public void SaveData()
    {
        string data = JsonUtility.ToJson(nowPlayer);
        File.WriteAllText(path + filename, data);
    }

    public void LoadData()
    {
        string data = File.ReadAllText(path + filename);
        nowPlayer = JsonUtility.FromJson<PlayerData>(data);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            nowPlayer.level = nowPlayer.level + 1;
            SaveData();
        }

        if (Input.GetKeyDown("l"))
        {
            LoadData();
            print(nowPlayer.level);

        }
    }

}
