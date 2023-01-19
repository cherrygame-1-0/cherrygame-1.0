using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    Transform target = null;
    public float enemyMoveSpeed;
<<<<<<< HEAD
=======
    [SerializeField]
    private Animator animator;
    //float enemyMoveSpeed = 20f;
>>>>>>> lhs_0.2

    private Transform gun;

    private Transform honey;
    //float enemyMoveSpeed = 20f;
    void start()
    {
        print("Ω√¿€");
    }
    // Update is called once per frame
    void Update()
    {
        gun = GameObject.Find("mixamorig:RightHand").transform.Find("gun_grab");
        honey = GameObject.Find("mixamorig:RightHand").transform.Find("honey_grab");

        //if (target != null)
        //{
        //    if (gun.gameObject.activeSelf == true || honey.gameObject.activeSelf == true)
        //    {
        //        print("???");
        //        Vector3 dir = target.position - transform.position;
        //        transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
        //    }
        //}


        if (target != null)
        {
<<<<<<< HEAD
            if (gun.gameObject.activeSelf == true || honey.gameObject.activeSelf == true)
            {

                Vector3 dir = target.position - transform.position;
                transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
            }
=======
            Vector3 dir = target.position - transform.position;
            
            transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
>>>>>>> lhs_0.2
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
    ///private void OnTriggerExit(Collider col)
    //{
    //    target = null;
    //    Debug.Log("Box Enemy:Target lost");
    //}

}
