using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    private Transform cube;

    // Start is called before the first frame update
    void Start()
    {

        cube = GameObject.Find("mixamorig: RightShoulder").transform.Find("mixamorig:RightHand");

        cube.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
