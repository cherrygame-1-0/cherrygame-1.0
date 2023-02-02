using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove2 : MonoBehaviour
{
    public Transform targetTransform;
    public Vector3 CameraOffset;
    Vector3 destination = new Vector3(0.5986536f, 6.771896f, 184.1656f);

    // Update is called once per frame
    void Update()
    {
        //if(GameObject.Find("player").GetComponent<colstage2>().GoalCheck==true)

        if (GameObject.Find("player").GetComponent<col2>().GoalCheck==true)


        {
            //transform.position = Vector3.MoveTowards(transform.position, destination, 0.3f);
            // transform.rotation = Quaternion.Euler(30, 180, 0);
        }
        else
        {
            transform.position = targetTransform.position + CameraOffset;
        }
    }


}
