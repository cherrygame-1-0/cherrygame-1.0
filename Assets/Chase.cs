using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    Transform target = null;
    public float enemyMoveSpeed;
    [SerializeField]
    private Animator animator;
    //float enemyMoveSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 dir = target.position - transform.position;
            
            transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
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

    private void OnTriggerExit(Collider col)
    {
        target = null;
        Debug.Log("Box Enemy:Target lost");
    }

}
