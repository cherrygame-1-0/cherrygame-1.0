using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Animation : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    float timer;
    int waitingTime;

   

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        waitingTime = 2;
        //inside = false;
    }

    // Update is called once per frame
    void Update()
    {   //public Animator CHR_ANIM;
        //CHR_ANIM.SetTrigger("PadeOut");

        animator.SetBool("IsMove", true);
        

        if (Input.GetKey(KeyCode.C))
        {
            animator.SetBool("Jump", true);




            
                
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetBool("Jump", false);
        }


    }
}
