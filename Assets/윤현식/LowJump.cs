using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowJump : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {

        GameObject.Find("player").GetComponent<PlayerMove>().lowjump();

    }
}
