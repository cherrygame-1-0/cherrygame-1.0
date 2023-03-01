using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 5;
    }
    private void Update()
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
            print("¸ÂÀ½");
        }
    }
}
