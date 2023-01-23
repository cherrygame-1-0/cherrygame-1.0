using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm_col : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("coinbgm").GetComponent<AudioSource>();

    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            audioSource.Play(); //음원을 실행하는 부분
        }
    }
}
