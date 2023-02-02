using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    GameObject obj;

    private Rigidbody rigid;

    public int JumpPower;
    public int MoveSpeed;
    public float runMoveSpeed =0.07f;
    private bool IsJumping;

    void Start()
    {
        obj = GameObject.Find("Monster");
        obj.GetComponent<Chase>().test();
        rigid = GetComponent<Rigidbody>();    
        IsJumping = false;                     
    }

    void Update()
    {
        
        Move();
        Jump();
    }

    void Move()
    {


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        transform.Translate((new Vector3(h, 0, 0) * MoveSpeed) * Time.deltaTime);
        transform.Translate(Vector3.forward * runMoveSpeed);

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


