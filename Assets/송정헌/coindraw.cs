using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coindraw : MonoBehaviour
{
    public static int? coin = 0;

    private void Start()
    {
        coin = 0;
    }
    private void Update()
    {
        GetComponent<Text>().text = coin.ToString();
    }
}
