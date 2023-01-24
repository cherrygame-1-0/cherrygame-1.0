using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coindraw : MonoBehaviour
{
    public static int coin = 0;

    private void Start()
    {
        coin = 0;
    }

    //public void GetScore()
    //{
    //    coin += 100;
    //    SetText();
    //}

    //public void SetText()
    //{
    //    text.text = "coin : " + coin.ToString();
    //}
    private void Update()
    {
        GetComponent<Text>().text = coin.ToString();
    }
}
