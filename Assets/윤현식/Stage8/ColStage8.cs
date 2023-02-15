using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColStage8 : MonoBehaviour
{
	[SerializeField]
	private Animator animator;


	string playerstage = "0";
	GameObject honeey;
	GameObject poison;
	GameObject obj1;
	GameObject obj2; // 다음 스테이지 넘어가려고
	public bool GoalCheck = false;
	public bool eathoney = false;
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


			if (other.gameObject.name == "poison")
			{
				honeey = GameObject.Find("honey");
				Destroy(honeey);
				Invoke("dead", 2f);

			}

			if (other.gameObject.name == "honey")
			{
				eathoney = true;
				poison = GameObject.Find("poison");
				Destroy(poison);

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("playerRightHand").transform.Find("honey_grab");
				print("꿀 획득");
				cube.gameObject.SetActive(true);
			}

			if (other.gameObject.name == "coin")
			{
				//coindraw.GetScore();
				coindraw.coin += 1;
				print("코인 획득");

			}

			if (other.gameObject.name == "armor")
			{

				print("아머");

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("playerbody").transform.Find("armor_grab");

				print("아머");
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
				dead();
				if (other.gameObject.name == "bomb")
				{
					print("폭탄충돌");
					cube = other.transform.Find("DYNAMITE");
					cube.gameObject.SetActive(true);
				}

			}


		}

		if (other.gameObject.tag == "goal") // 결승선 구현 코드

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

			print("레벨인식 " + GameObject.Find("datadase").GetComponent<database>().nowPlayer.level);

			GameObject.Find("datadase").GetComponent<database>().Savecall();

		}
	}
	void dead()
    {
		GameObject.Find("Monster").GetComponent<Chase>().target = null;

		GameObject.Find("player").GetComponent<PlayerMove>().runMoveSpeed = 0;
		GameObject.Find("player").GetComponent<PlayerMove>().MoveSpeed = 0;
		animator.SetBool("Die", true);
		Destroy(gameObject, 2);

		Debug.Log("GameOver");

		obj1 = GameObject.Find("Canvas");
		obj1.GetComponent<GameOverMenu>().Show();
	}
	void InvokeTest()
	{
		GameObject.Find("playerbody").transform.Find("armor_grab").gameObject.SetActive(false);
		print("보호막감소");
		gameObject.GetComponent<Rigidbody>().isKinematic = false;

	}
}
