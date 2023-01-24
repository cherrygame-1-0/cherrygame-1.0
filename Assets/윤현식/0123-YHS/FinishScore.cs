using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HIHIHIHI");
        GetComponent<Text>().text = coindraw.coin.ToString();
    }
}
