using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombstart : MonoBehaviour
{
    private Transform cube;
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
        if (other.gameObject.tag == "dieobject")
        {
            cube = gameObject.transform.Find("DYNAMITE");
            cube.gameObject.SetActive(true);

            GameObject.Find("Monster").GetComponent<monstermove>().Mondie = true;

            GameObject.Find("babyMonster").GetComponent<babymonster>().babyMondie = true;


            GameObject.Find("Monster").GetComponent<monstermove>().target = null;


            GameObject.Find("babyMonster").GetComponent<babymonster>().target = null;


            Destroy(gameObject, 0.3f);

        }

    }
}
