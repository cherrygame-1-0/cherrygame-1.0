using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colstage3 : MonoBehaviour
{
	[SerializeField]
	private Animator animator;


	string playerstage = "0";
	GameObject honeey;
	GameObject ggun;
	GameObject obj1;
	GameObject obj2; // ´ÙÀ½ ½ºÅ×ÀÌÁö ³Ñ¾î°¡·Á°í
	public bool GoalCheck = false;
	int result = 0;

	private Transform cube;

	public Animation anim;

	coindraw coindraw;
	void Start()
	{
		GameObject.Find("datadase").GetComponent<database>().Loadcall();
		print("start");
		coindraw = FindObjectOfType<coindraw>();
	}
	private void OnTriggerEnter(Collider col)
	{
		if (col.tag == "level")
		{
			print(col.transform.GetChild(0).gameObject.name);
			playerstage = col.transform.GetChild(0).gameObject.name;

		}
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

			if (other.gameObject.name == "armor")
			{

				print("¾Æ¸Ó");

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("playerbody").transform.Find("armor_grab");

				print("¾Æ¸Ó");
				cube.gameObject.SetActive(true);


			}


		}
		if (other.gameObject.tag == "dieobject")

		{

			if (GameObject.Find("playerbody").transform.Find("armor_grab").gameObject.activeSelf == true)
			{
				print("???");
				gameObject.GetComponent<Rigidbody>().isKinematic = true;

				Invoke("InvokeTest", 0.8f);

			}

			else
			{

				GameObject.Find("Monster").GetComponent<Chase>().target = null;

				GameObject.Find("player").GetComponent<PlayerMove>().runMoveSpeed = 0;
				GameObject.Find("player").GetComponent<PlayerMove>().MoveSpeed = 0;
				animator.SetBool("Die", true);
				Destroy(gameObject, 2);

				Debug.Log("GameOver");

				obj1 = GameObject.Find("Canvas");
				obj1.GetComponent<GameOverMenu>().Show();

				if (other.gameObject.name == "bomb")
				{
					print("ÆøÅºÃæµ¹");
					cube = other.transform.Find("DYNAMITE");
					cube.gameObject.SetActive(true);
				}
			}


		}

		if (other.gameObject.tag == "goal") // °á½Â¼± ±¸Çö ÄÚµå

		{
			GoalCheck = true;
			animator.SetBool("Clear", true);
			animator.SetBool("IsMove", false);
			animator.SetBool("Pistol", false);

			Debug.Log("Goal");
			GameObject.Find("player").GetComponent<PlayerMove>().runMoveSpeed = 0;
			GameObject.Find("player").GetComponent<PlayerMove>().MoveSpeed = 0;
			obj2 = GameObject.Find("Canvas");
			obj2.GetComponent<NextStage>().Show();

			GameObject.Find("datadase").GetComponent<database>().stage = int.Parse(playerstage);
			GameObject.Find("datadase").GetComponent<database>().nowlevel = int.Parse(playerstage) + 1;
			GameObject.Find("datadase").GetComponent<database>().nowcoin = (int)coindraw.coin;

			print("·¹º§ÀÎ½Ä " + GameObject.Find("datadase").GetComponent<database>().nowPlayer.level);

			GameObject.Find("datadase").GetComponent<database>().Savecall();

		}
	}

	void InvokeTest()
	{
		GameObject.Find("playerbody").transform.Find("armor_grab").gameObject.SetActive(false);
		print("º¸È£¸·°¨¼Ò");
		gameObject.GetComponent<Rigidbody>().isKinematic = false;

	}
}
