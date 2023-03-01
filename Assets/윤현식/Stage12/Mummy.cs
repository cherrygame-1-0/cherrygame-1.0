using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mummy : MonoBehaviour
{
    Transform target = null;
    float enemyMoveSpeed = 10f;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 2;
        print("인식");
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 dir = target.position + transform.position;
            transform.Translate(dir.normalized * enemyMoveSpeed * Time.deltaTime);
        }
        if (count == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.gameObject.transform;
        }
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "bullet")
        {
            count -= 1;
            print("맞음");
        }
    }
}
