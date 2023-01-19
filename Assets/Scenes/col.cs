using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
	[SerializeField]
	private Animator animator;
	private Transform cube;
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

			cube = GameObject.Find("player").transform.Find("gun_grab");

			Destroy(other.gameObject);

			if (other.gameObject.name == "gun")
			{

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("player").transform.Find("gun_grab");

				print("ÃÑ È¹µæ");
				cube.gameObject.SetActive(true);
				animator.SetBool("Pistol", true);

			}

			if (other.gameObject.name == "honey")
            {

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("player").transform.Find("honey_grab");
				print("²Ü È¹µæ");
				cube.gameObject.SetActive(true);
			}

			if (other.gameObject.name == "coin")
			{
				coindraw.GetScore();
				print("ÄÚÀÎ È¹µæ");

			}

		}

		if (other.gameObject.tag == "dieobject")
        {
			
			animator.SetBool("Die", true);
			//Destroy(gameObject);
		}


	}

}
