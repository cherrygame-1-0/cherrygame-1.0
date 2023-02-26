using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove_ST11 : MonoBehaviour
{
    public Transform targetTransform;
    public Vector3 CameraOffset;
    Vector3 destination = new Vector3(0.5986536f, 6.771896f, 184.1656f);
    public bool Goalpass = false;
    // Update is called once per frame
    void Update()
    {


        if (Goalpass == true )
        {
            print("Ä«¸Þ¶ó");
            transform.position = Vector3.MoveTowards(transform.position, destination, 0.3f);
            transform.rotation = Quaternion.Euler(30, 180, 0);
        }
        else
        {
            transform.position = targetTransform.position + CameraOffset;
        }
    }
}
