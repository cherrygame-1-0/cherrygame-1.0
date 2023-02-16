using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coindrop : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if ( GameObject.Find("Monster").GetComponent<monstermove>().Mondie == true)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }

    }
}
