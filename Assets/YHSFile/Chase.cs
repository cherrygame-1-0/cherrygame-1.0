using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    Transform target = null;
    public float enemyMoveSpeed;
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
        gun = GameObject.Find("mixamorig:RightHand").transform.Find("gun_grab");
        honey = GameObject.Find("mixamorig:RightHand").transform.Find("honey_grab");


        if (target != null)
        {
            if (gun.gameObject.activeSelf == true || honey.gameObject.activeSelf == true)
            {

                Vector3 dir = target.position - transform.position;
                transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            animator.SetBool("Target_Found", true);
            target = col.gameObject.transform;
            Debug.Log("Box Enemy:Target found");
        }
    }

    public void test()
    {
        print("zzz");
    }

}
