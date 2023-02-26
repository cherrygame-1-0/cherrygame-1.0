using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorout : MonoBehaviour
{
    // Start is called before the first frame update
    public int inout;
    GameObject camera;
    // Start is called before the first frame update
    void Start()
    {

        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame


    void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("player").GetComponent<PlayerMove>().runMoveSpeed = 11;
            GameObject.Find("player").GetComponent<PlayerMove>().MoveSpeed = 8;
            camera.gameObject.SetActive(true);
            print("Επΐε");

            Destroy(gameObject);

        }

    }
}
