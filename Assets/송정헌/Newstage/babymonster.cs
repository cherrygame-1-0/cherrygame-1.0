using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babymonster : MonoBehaviour
{
    public Transform target = null;
    public float enemyMoveSpeed;

    public bool babyMondie = false;

    float timer;
    int waitingTime;

    [SerializeField]
    private Animator animator;


    private Transform gun;

    private Transform honey;

    void start()
    {

        print("Ω√¿€");
    }

    void Update()
    {


        if (babyMondie == true)
        {
            transform.Rotate(new Vector3(0, 0, 100));
            Destroy(gameObject, 1);
        }

        gun = GameObject.Find("playerRightHand").transform.Find("gun_grab");
        honey = GameObject.Find("playerRightHand").transform.Find("honey_grab");




        if (target != null)
        {


            if (gun.gameObject.activeSelf == true || honey.gameObject.activeSelf == true || true)
            {

                Vector3 dir = target.position - transform.position;
                transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
                transform.LookAt(transform.position + dir);

            }
        }

        



    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("stop");
            target = null;
        }

        if (other.gameObject.tag == "bullet")
        {
            print("bullet");
            target = null;

            transform.Rotate(new Vector3(0, 0, 100));
            Destroy(gameObject, 1);
        }

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
