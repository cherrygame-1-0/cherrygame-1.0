using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spot;
    private Transform cube;
    public bool Shot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shot = GameObject.Find("Canvas").GetComponent<Action_Btn>().Action;

        cube = GameObject.Find("playerRightHand").transform.Find("gun_grab");

        if (cube.gameObject.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject obj = Instantiate(bullet, spot.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody>().AddForce(spot.transform.forward * 1500f);
                print("발사");
                Destroy(obj, 5);
            }

            if (Shot == true)
            {
                GameObject obj = Instantiate(bullet, spot.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody>().AddForce(spot.transform.forward * 1500f);
                print("발사");
                Destroy(obj, 5);
                
            }
        }

        Shot = false;

    }

}
