using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
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

        cube = GameObject.Find("mixamorig:RightHand").transform.Find("gun_grab");

        if (cube.gameObject.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject obj = Instantiate(bullet, spot.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody>().AddForce(spot.transform.forward * 1500f);
                print("น฿ป็");
                Destroy(obj, 5);
            }
        }

    }

}
