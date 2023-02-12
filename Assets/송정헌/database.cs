using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerData
{
    public int level;
    public int coin;
    public int[] stagecoin = new int[30];


}
public class database : MonoBehaviour
{
    public static int asd = 1;



    public int stage;
    public int nowlevel = 0;
    public int nowcoin;


    string path;
    string filename = "save";

    public static database instance;

    private void Awake()
    {
        path = Application.persistentDataPath + "/";
    }
    public PlayerData nowPlayer = new PlayerData();


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i< 30; i++)
        {
            nowPlayer.stagecoin[i] = 0;
        }

        nowlevel = 1;
        nowcoin = 0;

        nowPlayer.level = nowlevel;
        nowPlayer.coin = nowcoin;
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
        if (Input.GetKeyDown("n"))
        {
            nowPlayer.level = 1;
            nowPlayer.coin = 0;
            for (int i = 1; i < 30; i++)
            {
                nowPlayer.stagecoin[i] = 0;
            }
            SaveData();
        }

        if (Input.GetKeyDown("k"))
        {
            nowPlayer.level = 10;
            nowPlayer.coin = 0;
            for (int i = 1; i < 30; i++)
            {
                nowPlayer.stagecoin[i] = 0;
            }
            SaveData();
        }


        if (Input.GetKeyDown("s"))
        {
            if(nowPlayer.level <= nowlevel){
                nowPlayer.level = nowlevel;
            }

           
            nowPlayer.coin = nowcoin;
            nowPlayer.stagecoin[stage] = nowcoin;
            SaveData();
        }

        if (Input.GetKeyDown("l"))
        {
            LoadData();

            print("level = " + nowPlayer.level);

            for (int i = 1; i < 30; i++)
            {
                print("stage" + i + " 코인 = " + nowPlayer.stagecoin[i]);
            }

            for (int i = 1; i < 30; i++)
            {
                nowPlayer.stagecoin[0] = nowPlayer.stagecoin[0] + nowPlayer.stagecoin[i];
            }
            nowPlayer.coin = nowPlayer.stagecoin[0];
            print("전체 코인 개수 = " + nowPlayer.stagecoin[0]);

            //print(nowPlayer.stagecoin[1]);

        }
    }
    public void Savecall()
    {
        if (nowPlayer.level <= nowlevel)
        {
            nowPlayer.level = nowlevel;
        }


        nowPlayer.coin = nowcoin;
        nowPlayer.stagecoin[stage] = nowcoin;
        SaveData();
    }

    public void Loadcall()
    {
        LoadData();

        print("level = " + nowPlayer.level);

        for (int i = 1; i < 30; i++)
        {
            print("stage" + i + " 코인 = " + nowPlayer.stagecoin[i]);
        }

        for (int i = 1; i < 30; i++)
        {
            nowPlayer.stagecoin[0] = nowPlayer.stagecoin[0] + nowPlayer.stagecoin[i];
        }
        nowPlayer.coin = nowPlayer.stagecoin[0];
        print("전체 코인 개수 = " + nowPlayer.stagecoin[0]);

        //print(nowPlayer.stagecoin[1]);
    }

}
