using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bow : MonoBehaviour
{
    Vector3 pos; //현재위치
    private bool bowstart = false;
    float delta = 1.0f; // 좌(우)로 이동가능한 (x)최대값

    float speed = 3.5f; // 이동속도
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (bowstart == true)
        {
            transform.Translate(Vector3.back * 10 * Time.deltaTime, Space.World);
        }

    }
    private void OnTriggerEnter(Collider col)
    {
        bowstart = true;
    }

}