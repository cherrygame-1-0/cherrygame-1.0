using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageThemeopen : MonoBehaviour
{
    int stagelevelopen;

    int stagelevelopen_Theme;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("datadase").GetComponent<database>().Loadcall();
        stagelevelopen = GameObject.Find("datadase").GetComponent<database>().nowPlayer.level;
        print(transform.GetChild(0));
        print(stagelevelopen);

        stagelevelopen = 11;

        stagelevelopen_Theme = stagelevelopen / 10;

        print("�׸� ���� ���");
        print(stagelevelopen_Theme);
    }

    // Update is called once per frame
    void Update()
    {



        for (int i = 7; i < 7 + stagelevelopen_Theme; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
