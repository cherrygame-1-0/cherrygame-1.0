using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public Transform target = null;
    public float enemyMoveSpeed;


    float timer;
    int waitingTime;

    [SerializeField]
    private Animator animator;

    GameObject Heart;
    GameObject Threat;

    private Transform gun;

    private Transform honey;

    void start()
    {

        print("Ω√¿€");
    }

    void Update()
    {


        gun = GameObject.Find("playerRightHand").transform.Find("gun_grab");
        honey = GameObject.Find("playerRightHand").transform.Find("honey_grab");




        if (target != null)
        {


            if (gun.gameObject.activeSelf == true || honey.gameObject.activeSelf == true)
            {

                Vector3 dir = target.position - transform.position;
                transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
                transform.LookAt(transform.position + dir);
            }

            if (honey.gameObject.activeSelf == true)
            {
                Heart = GameObject.Find("Monster").transform.Find("Heart").gameObject;
                Heart.gameObject.SetActive(true);
            }

            if (gun.gameObject.activeSelf == true)
            {
                Threat = GameObject.Find("Monster").transform.Find("Threat").gameObject;
                Threat.gameObject.SetActive(true);
            }
        }



    }
    void OnCollisionEnter(Collision other)
    {
        print("stop");
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {   
            target = col.gameObject.transform;
            animator.SetBool("Target_Found", true);
            Debug.Log("Box Enemy:Target found");

        }
    }

    public void test()
    {
        print("zzz");
    }

}
