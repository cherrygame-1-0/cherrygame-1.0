using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMove : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    GameObject obj1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiting());
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "goal")
        {
            obj1 = GameObject.Find("Player");
            obj1.GetComponent<Col_Stage12>().Die();
        }
    }

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(10.0f);
    }
}
