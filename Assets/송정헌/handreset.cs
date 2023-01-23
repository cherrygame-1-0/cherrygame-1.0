using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handreset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            GameObject.Find("playerRightHand").transform.Find("gun_grab").gameObject.SetActive(false);
            GameObject.Find("playerRightHand").transform.Find("honey_grab").gameObject.SetActive(false);

            print("장비 내려놓음");

        }
    }

}
