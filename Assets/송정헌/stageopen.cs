using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageopen : MonoBehaviour
{
    int stagelevelopen;
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
            for (int i = stagelevelopen; i < 10; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        stagelevelopen = GameObject.Find("datadase").GetComponent<database>().nowPlayer.level;
        //print(stagelevelopen);
        for (int i = stagelevelopen; i < 10; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

    }
}
