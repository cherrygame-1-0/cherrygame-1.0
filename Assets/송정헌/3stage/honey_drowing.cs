using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class honey_drowing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public GameObject spot;
    private Transform cube;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

 cube = GameObject.Find("playerRightHand").transform.Find("honey_grab");

        if (cube.gameObject.activeSelf == true)
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {

                GameObject obj = Instantiate(bullet, spot.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody>().AddForce(spot.transform.forward * 1000f);

                cube.gameObject.SetActive(false);

                GameObject.Find("Monster").GetComponent<monstermove>().target = obj.transform;


            }

        }
        
    }
}
