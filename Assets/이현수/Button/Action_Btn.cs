using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Btn : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Action;
    public int Gun;

    void Start()
    {
        Gun = 0;
    }
    // Update is called once per frame
    void Update()
    {
        

    }
    public void PointerDown()
    {
        Action = true;
        
      

    }

    public void PointerUp()
    {
        Action = false;

    }
    public void OnClickAction()
    {
        Gun += 1;
        //Action = true;
        print("액션 입력 버튼");
    }
}
