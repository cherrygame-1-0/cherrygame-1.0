using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bow : MonoBehaviour
{
    Vector3 pos; //������ġ
    private bool bowstart = false;
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