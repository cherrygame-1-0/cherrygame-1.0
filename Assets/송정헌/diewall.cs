using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diewall : MonoBehaviour
{
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 5;
        print("인식");
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "bullet")
        {
            count -= 1;
            print("맞음");
        }
    }
}

