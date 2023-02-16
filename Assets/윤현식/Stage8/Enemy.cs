using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Delay;
    public EnemyGun EG;
    // Start is called before the first frame update
    void Start()
    {
        Delay = 10;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("АјАн");
            EG.Attack();
        }
    }
}
