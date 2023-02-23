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

        //stagelevelopen = 20;

        stagelevelopen_Theme = stagelevelopen / 10;

        print("테마 레벨 출력");
        print(stagelevelopen_Theme);
    }

    // Update is called once per frame
    void Update()
    {
        print("테마 레벨 출력");
        print(stagelevelopen_Theme);

        for (int i = stagelevelopen_Theme + 2; i < 7; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
