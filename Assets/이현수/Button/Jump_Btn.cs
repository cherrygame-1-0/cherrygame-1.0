using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Btn : MonoBehaviour
{
    public bool inputJump;
    void Update()
    {
        
    }

    public void PointerDown()
    {
        inputJump = true;

    }

    public void PointerUp()
    {
        inputJump = false;

    }

    public void OnClickJump_Btn()
    {
        print("점프 입력 버튼");
    }
}
