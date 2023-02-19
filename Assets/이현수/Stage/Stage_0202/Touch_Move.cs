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
            float speed = Time.deltaTime * 10f; // 움직이게할 속도
            Vector3 tpos = Input.GetTouch(0).position; //터치좌표를 가져옴
            if ((tpos.y >= Screen.height / 3)&&(tpos.x <= Screen.width / 2)) // 왼쪽
            {
                transform.Translate(-Vector3.right * speed); //이동
            }
            else if ((tpos.y >= Screen.height / 3)&&(tpos.x >= Screen.width / 2)) //오른쪽
            {
                transform.Translate(Vector3.right * speed); //이동
            }

            else if ((tpos.y <= Screen.height / 7) && (tpos.x <= Screen.width / 2)) // 왼쪽
            {
                transform.Translate(-Vector3.right * speed); //이동
            }

            else if ((tpos.y <= Screen.height / 7) && (tpos.x >= Screen.width / 2)) //오른쪽
            {
                transform.Translate(Vector3.right * speed); //이동
            }




        }
    }
}