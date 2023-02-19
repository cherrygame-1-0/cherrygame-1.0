using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col_ST10 : MonoBehaviour
{

	[SerializeField]
	private Animator animator;

	public int ColorNum = 0;

	string playerstage = "0";
	GameObject honeey;
	GameObject ggun;
	GameObject ggun2;

	GameObject obj1;
	GameObject G_Btn;
	GameObject T_Btn;
	GameObject obj2; // ´ÙÀ½ ½ºÅ×ÀÌÁö ³Ñ¾î°¡·Á°í
	private Transform Bear1;
	public bool GoalCheck = false;
	int result = 0;

	private Transform cube;
	private Transform cube2;
	public Animation anim;

	public int _Speed = 8;
	public int _Jump_P = 10;
	//public int _fight;

	coindraw coindraw;
	void Start()
	{
		cube = GameObject.Find("mixamorig:RightToeBase2").transform.Find("R_Foot");
		cube2 = GameObject.Find("mixamorig:LeftToeBase3").transform.Find("L_Foot");
		Bear1 = GameObject.Find("HideBear").transform.Find("H_Bear");

		print("col ÀÛµ¿ÇÔ?");
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

			cube = GameObject.Find("mixamorig:RightToeBase2").transform.Find("R_Foot");
			cube2 = GameObject.Find("mixamorig:LeftToeBase3").transform.Find("L_Foot");

			




			Destroy(other.gameObject);


			if (other.gameObject.name == "Jump")
			{
				G_Btn = GameObject.Find("Canvas").transform.Find("Action_C").gameObject;
				//G_Btn.gameObject.SetActive(true);

				_Jump_P = 30;
				honeey = GameObject.Find("Speed");
				Destroy(honeey);

				ggun2 = GameObject.Find("Power");
				Destroy(honeey);

				cube.gameObject.SetActive(true);
				cube2.gameObject.SetActive(true);

				ColorNum = 2;

				print("Á¡ÇÁ È¹µæ");
				
			}

			if (other.gameObject.name == "Speed")
			{
				G_Btn = GameObject.Find("Canvas").transform.Find("Action_C").gameObject;
				//G_Btn.gameObject.SetActive(true);

				_Speed = 15;
				ggun = GameObject.Find("Jump");
				Destroy(ggun);

				ggun2 = GameObject.Find("Power");
				Destroy(honeey);

				cube.gameObject.SetActive(true);
				cube2.gameObject.SetActive(true);

				ColorNum = 1;

				print("½ºÇÇµå È¹µæ");
				
			}

			if (other.gameObject.name == "Power")
			{
				G_Btn = GameObject.Find("Canvas").transform.Find("Action_C").gameObject;
				//G_Btn.gameObject.SetActive(true);

				Bear1.gameObject.SetActive(true);

				ggun = GameObject.Find("Jump");
				Destroy(ggun);

				ggun2 = GameObject.Find("Speed");
				Destroy(honeey);

				cube.gameObject.SetActive(true);
				cube2.gameObject.SetActive(true);

				ColorNum = 0;
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
}
