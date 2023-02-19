using UnityEngine;
using System.Collections;

public class Touch_Move : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            float speed = Time.deltaTime * 10f; // �����̰��� �ӵ�
            Vector3 tpos = Input.GetTouch(0).position; //��ġ��ǥ�� ������
            if ((tpos.y >= Screen.height / 3)&&(tpos.x <= Screen.width / 2)) // ����
            {
                transform.Translate(-Vector3.right * speed); //�̵�
            }
            else if ((tpos.y >= Screen.height / 3)&&(tpos.x >= Screen.width / 2)) //������
            {
                transform.Translate(Vector3.right * speed); //�̵�
            }

            else if ((tpos.y <= Screen.height / 7) && (tpos.x <= Screen.width / 2)) // ����
            {
                transform.Translate(-Vector3.right * speed); //�̵�
            }

            else if ((tpos.y <= Screen.height / 7) && (tpos.x >= Screen.width / 2)) //������
            {
                transform.Translate(Vector3.right * speed); //�̵�
            }




        }
    }
}