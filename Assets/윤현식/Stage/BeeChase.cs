using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeChase : MonoBehaviour
{
    public Transform target = null;
    public float enemyMoveSpeed;

    [SerializeField]

    private Transform lemon;

    private Transform honey;

    void start()
    {

        print("Ω√¿€");
    }

    void Update()
    {


        honey = GameObject.Find("playerRightHand").transform.Find("honey_grab");

        if (target != null)
        {


            //if (honey.gameObject.activeSelf == true)
            //{

            //    Vector3 dir = target.position - transform.position;
            //    transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
            //    transform.LookAt(transform.position + dir);
            //}

            if (GameObject.Find("player").GetComponent<col2>().eathoney == true)
            {

                Vector3 dir = target.position - transform.position;
                transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
                transform.LookAt(transform.position + dir);
            }
            else
            {
                Vector3 dir = target.position - transform.position;
                transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
                transform.LookAt(transform.position - dir);
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            target = col.gameObject.transform;
            Debug.Log("Box Enemy:Target found");

        }
    }

    public void test()
    {
        print("zzz");
    }

}
