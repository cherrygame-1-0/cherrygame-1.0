using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage5_BeeMove : MonoBehaviour
{

    Vector3 destination = new Vector3(-4.79f, -1.29f, 100.2621f);
    Vector3 destination2 = new Vector3(3.06f, -1.29f, 100.2621f);
    Vector3 destination3 = new Vector3(4.74f, -1.29f, 91.53767f);
    Vector3 destination4 = new Vector3(4.27f, -1.29f, 100.1799f);

    // Update is called once per frame
    void Update()
    {
        //3.06 -1.29 100.2621
        //transform.position = Vector3.MoveTowards(transform.position, destination, 1);
        //transform.rotation = Quaternion.Euler(0, 0, 0);
        //transform.position = Vector3.MoveTowards(transform.position, destination2, 1);
        //transform.rotation = Quaternion.Euler(0, -90, 0);
        //transform.position = Vector3.MoveTowards(transform.position, destination3, 1);
        //transform.rotation = Quaternion.Euler(0, -180, 0);
        //transform.position = Vector3.MoveTowards(transform.position, destination4, 1);
        //transform.rotation = Quaternion.Euler(0, -270, 0);
        transform.position = Vector3.MoveTowards(transform.position, destination, 3);
        transform.rotation = Quaternion.Euler(0, -90, 0);
        transform.position = Vector3.MoveTowards(transform.position, destination2, 1);
        transform.rotation = Quaternion.Euler(0, 90, 0);

    }
}
