using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Rigidbody cube;

    private void Start()
    {
        StartCoroutine(MoveObject());
    }
    IEnumerator MoveObject()
    {
        cube = GetComponent<Rigidbody>();

        while(true)
        {
            float dir1 = Random.Range(-1f, 1f);
            float dir2 = Random.Range(34f, 35f);

            yield return new WaitForSeconds(2);
            cube.velocity = new Vector3(dir1, 2, dir2);
        }
    }
}
