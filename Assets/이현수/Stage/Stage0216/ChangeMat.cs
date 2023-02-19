using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    public Material[] mat = new Material[2];

    public int i = 0;

    

    public void ChangeCubeMat()
    {
        i = GameObject.Find("player").GetComponent<Col_ST10>().ColorNum;

        // Change Material
        gameObject.GetComponent<MeshRenderer>().material = mat[i];
    }

    void Update()
    {
        ChangeCubeMat();
    }
}