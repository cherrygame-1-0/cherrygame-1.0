using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{

	GameObject honeey;
	GameObject ggun;
	GameObject obj1;
	int result = 0;
	private Transform cube;


	[SerializeField]
	private Animator animator;
	public Animation anim;

	coindraw coindraw;
	void Start()
    {
		print("start");
		coindraw = FindObjectOfType<coindraw>();
	}

	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.tag == "object")
		{

			cube = GameObject.Find("mixamorig:RightHand").transform.Find("gun_grab");
			Destroy(other.gameObject);

			print("ø¿∫Í¡ß∆Æ »Æ¿Œ");

			if (other.gameObject.name == "gun")
			{

				
				
				honeey = GameObject.Find("honey");
				Destroy(honeey);

				//cube.gameObject.SetActive(false);
				print("√—»Æ¿Œ");
				cube = GameObject.Find("mixamorig:RightHand").transform.Find("gun_grab");

				print("√— »πµÊ");
				cube.gameObject.SetActive(true);
				animator.SetBool("Pistol", true);

			}

			if (other.gameObject.name == "honey")
            {
				ggun = GameObject.Find("gun");
				Destroy(ggun);

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("mixamorig:RightHand").transform.Find("honey_grab");
				print("≤‹ »πµÊ");
				cube.gameObject.SetActive(true);
			}

			if (other.gameObject.name == "coin")
			{
				//coindraw.GetScore();
				//result += 1;
				print("ƒ⁄¿Œ »πµÊ");

			}

		}
		if (other.gameObject.tag == "dieobject")
		{
			Debug.Log("GameOver");
			//StopAllCoroutines();
			Destroy(gameObject,2);

			obj1 = GameObject.Find("Canvas");
			obj1.GetComponent<GameOverMenu>().Show();
			animator.SetBool("Die", true);
		}

	}

}
