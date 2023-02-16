using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage8_Bee : MonoBehaviour
{
    public Transform target = null;
    public float enemyMoveSpeed;

    [SerializeField]

    private Transform lemon;

    private Transform honey;

    void Update()
    {


        honey = GameObject.Find("playerRightHand").transform.Find("honey_grab");

        if (target != null)
        {

            if (GameObject.Find("player").GetComponent<ColStage8>().eathoney == true)
            {

                Vector3 dir = target.position - transform.position;
                transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
                transform.LookAt(transform.position + dir);
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
}
