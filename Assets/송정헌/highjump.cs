using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highjump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {

        print("슈퍼점프 인식");

        print("슈퍼점프 시작");
        GameObject.Find("player").GetComponent<PlayerMove>().highjump();

    }

}
