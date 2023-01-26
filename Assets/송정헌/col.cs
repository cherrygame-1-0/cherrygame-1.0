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
	GameObject obj2; // ´ÙÀ½ ½ºÅ×ÀÌÁö ³Ñ¾î°¡·Á°í
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

				print("ÃÑ È¹µæ");
				cube.gameObject.SetActive(true);
				animator.SetBool("Pistol", true);

			}

			if (other.gameObject.name == "honey")
            {
				ggun = GameObject.Find("gun");
				Destroy(ggun);

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("playerRightHand").transform.Find("honey_grab");
				print("²Ü È¹µæ");
				cube.gameObject.SetActive(true);
			}

			if (other.gameObject.name == "coin")
			{
				//coindraw.GetScore();
				coindraw.coin += 1;
				print("ÄÚÀÎ È¹µæ");

			}

		}
		if (other.gameObject.tag == "dieobject")

        {
			GameObject.Find("Monster").GetComponent<Chase>().target = null;

			GameObject.Find("player").GetComponent<PlayerMove>().runMoveSpeed = 0;
			GameObject.Find("player").GetComponent<PlayerMove>().MoveSpeed = 0;
			animator.SetBool("Die", true);
			Destroy(gameObject,2);

			Debug.Log("GameOver");

			obj1 = GameObject.Find("Canvas");
			obj1.GetComponent<GameOverMenu>().Show();

		}

		if (other.gameObject.tag == "goal") // °á½Â¼± ±¸Çö ÄÚµå

		{
			Debug.Log("Goal");

			obj2 = GameObject.Find("Canvas");
			obj2.GetComponent<NextStage>().Show();

		}
	}

}
