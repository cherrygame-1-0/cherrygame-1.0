using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    private void Update()
    {
        transform.Rotate(new Vector3(0, 50f*Time.deltaTime, 0));
    }

}
