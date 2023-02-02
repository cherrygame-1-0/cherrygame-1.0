using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    GameObject obj;

    private Rigidbody rigid;

    public int JumpPower;
    public int MoveSpeed;
    public float runMoveSpeed;
    private bool IsJumping;
    public bool jumpBtn = false;

    void Start()
    {
        Application.targetFrameRate = 240;
        obj = GameObject.Find("Monster");
        obj.GetComponent<Chase>().test();
        rigid = GetComponent<Rigidbody>();    
        IsJumping = false;                     
    }

    void Update()
    {
        jumpBtn = GameObject.Find("Canvas").GetComponent<Jump_Btn>().inputJump;
        //print(jumpBtn);
        Move();
        Jump();
    }

    void Move()
    {


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        transform.Translate((new Vector3(h, 0, 0) * MoveSpeed) * Time.deltaTime);
        //transform.Translate(((new Vector3(0, 0, 10) * runMoveSpeed * Time.deltaTime)));
        transform.Translate((Vector3.forward * runMoveSpeed * Time.deltaTime));

    }

    void Jump()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            print("ss");
            if (!IsJumping)
            {
                IsJumping = true;
                rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);

            }

            else
            {

                return;
            }
        }

        if (jumpBtn == true)
        {
            print("ss");
            if (!IsJumping)
            {
                IsJumping = true;
                rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);

            }

            else
            {

                return;
            }
        }



    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Plane")
        {
            IsJumping = false;
        }
    }

    public void highjump()
    {
        print("전달받음");
        rigid.AddForce(Vector3.up * JumpPower * 2, ForceMode.Impulse);
    }

    public void lowjump()
    {
        rigid.AddForce(Vector3.up * JumpPower * 1.4f, ForceMode.Impulse);
    }
}


