using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
