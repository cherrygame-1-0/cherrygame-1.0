using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bow : MonoBehaviour
{
    Vector3 pos; //������ġ

    float delta = 1.0f; // ��(��)�� �̵������� (x)�ִ밪

    float speed = 3.5f; // �̵��ӵ�
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = pos;

        v.z -= delta * (Time.time * speed);

        transform.position = v;

        //transform.Rotate(new Vector3(0 , 100 * Time.deltaTime, 0));
    }

}
