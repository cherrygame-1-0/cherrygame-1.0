using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombdrawing : MonoBehaviour
{
    public GameObject bullet;

    public GameObject bullet2;

    public GameObject spot;

    private Transform cube;
    private Transform cube2;

    private bool bomb = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        bomb = GameObject.Find("Canvas").GetComponent<Action_Btn>().Action;

        cube = GameObject.Find("playerRightHand").transform.Find("bomb_grab");

        cube2 = GameObject.Find("playerRightHand").transform.Find("Hbomb_grab");




        if (cube.gameObject.activeSelf == true)
        {
            print("찾음");
            if (Input.GetKeyDown(KeyCode.Space))
            {

                GameObject obj = Instantiate(bullet, spot.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody>().AddForce(spot.transform.forward * 1000f);

                cube.gameObject.SetActive(false);

                //GameObject.Find("Monster").GetComponent<monstermove>().target = obj.transform;
            }
            if (bomb == true)
            {
                GameObject obj = Instantiate(bullet, spot.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody>().AddForce(spot.transform.forward * 1000f);

                cube.gameObject.SetActive(false);
            }
        }

        if (cube2.gameObject.activeSelf == true)
        {
            print("찾음");

            if (Input.GetKeyDown(KeyCode.Space))
            {

                GameObject obj = Instantiate(bullet2, spot.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody>().AddForce(spot.transform.forward * 1000f);

                cube2.gameObject.SetActive(false);

                GameObject.Find("Monster").GetComponent<monstermove>().target = obj.transform;
                GameObject.Find("babyMonster").GetComponent<babymonster>().target = obj.transform;

                GameObject.Find("Canvas").transform.Find("Action_C").gameObject.SetActive(false);

            }


            if (bomb == true)
            {
                GameObject obj = Instantiate(bullet2, spot.transform.position, Quaternion.identity);
                obj.GetComponent<Rigidbody>().AddForce(spot.transform.forward * 1000f);

                cube2.gameObject.SetActive(false);

                GameObject.Find("Monster").GetComponent<monstermove>().target = obj.transform;
                GameObject.Find("babyMonster").GetComponent<babymonster>().target = obj.transform;


                GameObject.Find("Canvas").transform.Find("Action_C").gameObject.SetActive(false);
            }
        }



    }
}
