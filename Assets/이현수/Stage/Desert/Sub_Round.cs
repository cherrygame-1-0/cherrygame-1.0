using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sub_Round : MonoBehaviour
{
    GameObject SplashObj;
    public int DoorNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        SplashObj = GameObject.Find("Canvas").transform.Find("Panel2").gameObject;
    }
    
    // Update is called once per frame
    void Update()
    {
        DoorNum = GameObject.Find("player").GetComponent<Col_ST11>().ColorNum;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Door2"))
        {
            SplashObj.SetActive(true);
        }



        if (collision.collider.gameObject.CompareTag("Door"))
        {
            SceneManager.LoadScene("2_Stage_Sub");
        }


        if (collision.collider.gameObject.CompareTag("Door_Out"))
        {
            if(DoorNum == 1)
            {
                SceneManager.LoadScene("2_Stage1_S");
            }
            
            else if (DoorNum == 2)
            {
                SceneManager.LoadScene("2_Stage1_J");
            }
        }

    }
}
