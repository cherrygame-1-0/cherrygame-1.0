using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{

	[SerializeField]
	private Animator animator;

	GameObject honeey;
	GameObject ggun;
	GameObject obj1;
	int result = 0;

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

			cube = GameObject.Find("playerRightHand").transform.Find("gun_grab");



			Destroy(other.gameObject);


			if (other.gameObject.name == "gun")
			{
				honeey = GameObject.Find("honey");
				Destroy(honeey);

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("playerRightHand").transform.Find("gun_grab");

				print("�� ȹ��");
				cube.gameObject.SetActive(true);
				animator.SetBool("Pistol", true);

			}

			if (other.gameObject.name == "honey")
            {
				ggun = GameObject.Find("gun");
				Destroy(ggun);

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("playerRightHand").transform.Find("honey_grab");
				print("�� ȹ��");
				cube.gameObject.SetActive(true);
			}

			if (other.gameObject.name == "coin")
			{
				coindraw.GetScore();
				result += 1;
				print("���� ȹ��");

			}

		}
		if (other.gameObject.tag == "dieobject")

        {
			
			animator.SetBool("Die", true);

			Destroy(gameObject,2);

			Debug.Log("GameOver");

			obj1 = GameObject.Find("Canvas");
			obj1.GetComponent<GameOverMenu>().Show();

		}

	}

}
