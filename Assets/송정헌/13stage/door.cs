using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public int inout;
    GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        inout = 1;
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {

        print(inout);
    }
    
    void OnCollisionEnter(Collision other)
    {


        if (inout == 1)
        {
            if (other.gameObject.tag == "Player")
            {
                inout = 2;

                GameObject.Find("player").GetComponent<PlayerMove>().runMoveSpeed = 0;
                GameObject.Find("player").GetComponent<PlayerMove>().MoveSpeed = 0;
                camera.gameObject.SetActive(false);
                print("¿‘¿Â");
                print(inout);
                print("inout");
                Destroy(gameObject);

            }


        }


        else
        {
            if (other.gameObject.tag == "Player")
            {
                GameObject.Find("player").GetComponent<PlayerMove>().runMoveSpeed = 11;
                GameObject.Find("player").GetComponent<PlayerMove>().MoveSpeed = 8;
                camera.gameObject.SetActive(true);
                print("≈¿Â");
                inout = 1;
                Destroy(gameObject);

            }
        }

    }
}
