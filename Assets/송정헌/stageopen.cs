using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageopen : MonoBehaviour
{
    int stagelevelopen;
    int stagestar = 3;
    // Start is called before the first frame update
    void Start()
    {

        //for (int i = 0; i < 10; i++);
        GameObject.Find("datadase").GetComponent<database>().Loadcall();
        stagelevelopen = GameObject.Find("datadase").GetComponent<database>().nowPlayer.level;
        print(transform.GetChild(0));
        print(stagelevelopen);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("n"))
        //{
        //    GameObject.Find("datadase").GetComponent<database>().nowPlayer.level = 10;
        //    for (int i = stagelevelopen; i < 10; i++)
        //    {
        //        transform.GetChild(i).gameObject.SetActive(true);
        //    }
        //}

        if (Input.GetKeyDown("k"))
        {
            GameObject.Find("datadase").GetComponent<database>().nowPlayer.level = 10;
            for (int i = stagelevelopen+10; i < 20; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        //GameObject.Find("datadase").GetComponent<database>().nowPlayer.level = 2;

        stagelevelopen = GameObject.Find("datadase").GetComponent<database>().nowPlayer.level;
        //print(stagelevelopen);
        for (int i = stagelevelopen+10; i < 20; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }




        for (int i = 1; i < 30; i++)
        {
            print("stage" + i + " 코인 왜 저장안되는거야 스테이지 열림 = " + GameObject.Find("datadase").GetComponent<database>().nowPlayer.stagecoin[i]);
            
        }


        //GameObject.Find("datadase").GetComponent<database>().nowPlayer.stagecoin[1] = 2;

        //GameObject.Find("datadase").GetComponent<database>().nowPlayer.stagecoin[2] = 2;


        for (int i = 10; i < stagelevelopen + 10; i++)
        {
            stagestar = GameObject.Find("datadase").GetComponent<database>().nowPlayer.stagecoin[i - 9];

            print(stagestar);
            if (stagestar >= 3)
            {
                stagestar = 3;
            }
            for (int j = 1; j <= stagestar; j++)
            {
                transform.GetChild(i).transform.GetChild(j).gameObject.SetActive(true);

            }

        }



    }
}
