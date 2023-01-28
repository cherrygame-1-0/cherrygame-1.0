using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coindraw : MonoBehaviour
{
    public static int? coin = 0;
    Text v;
    private void Start()
    {
        coin = 0;
        v = GetComponent<Text>();
    }
    private void Update()
    {
        v.text = coindraw.coin.ToString();
    }
}
