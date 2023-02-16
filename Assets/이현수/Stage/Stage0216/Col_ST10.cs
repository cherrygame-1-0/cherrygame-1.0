using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col_ST10 : MonoBehaviour
{

	[SerializeField]
	private Animator animator;



	string playerstage = "0";
	GameObject honeey;
	GameObject ggun;
	GameObject ggun2;

	GameObject obj1;
	GameObject G_Btn;
	GameObject T_Btn;
	GameObject obj2; // ���� �������� �Ѿ����
	public bool GoalCheck = false;
	int result = 0;

	private Transform cube;
	private Transform cube2;
	public Animation anim;

	coindraw coindraw;
	void Start()
	{
		print("col �۵���?");
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

			cube = GameObject.Find("mixamorig:RightToeBase").transform.Find("R_Foot");
			cube2 = GameObject.Find("mixamorig:LeftToeBase").transform.Find("L_Foot");
			Destroy(other.gameObject);


			if (other.gameObject.name == "Jump")
			{
				G_Btn = GameObject.Find("Canvas").transform.Find("Action_B").gameObject;
				G_Btn.gameObject.SetActive(true);


				honeey = GameObject.Find("Speed");
				Destroy(honeey);

				ggun2 = GameObject.Find("Power");
				Destroy(honeey);

				

				print("���� ȹ��");
				
			}

			if (other.gameObject.name == "Speed")
			{
				G_Btn = GameObject.Find("Canvas").transform.Find("Action_C").gameObject;
				G_Btn.gameObject.SetActive(true);


				ggun = GameObject.Find("Jump");
				Destroy(ggun);

				ggun2 = GameObject.Find("Power");
				Destroy(honeey);


				print("���ǵ� ȹ��");
				
			}

			if (other.gameObject.name == "Power")
			{
				G_Btn = GameObject.Find("Canvas").transform.Find("Action_C").gameObject;
				G_Btn.gameObject.SetActive(true);


				ggun = GameObject.Find("Jump");
				Destroy(ggun);

				ggun2 = GameObject.Find("Speed");
				Destroy(honeey);

			}



			if (other.gameObject.name == "coin")
			{
				//coindraw.GetScore();
				coindraw.coin += 1;
				print("���� ȹ��");

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
				print("��ź�浹");
				cube = other.transform.Find("DYNAMITE");
				cube.gameObject.SetActive(true);
			}

		}

		if (other.gameObject.tag == "goal") // ��¼� ���� �ڵ�

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

			print("�����ν� " + GameObject.Find("datadase").GetComponent<database>().nowPlayer.level);

			GameObject.Find("datadase").GetComponent<database>().Savecall();

		}
	}
}
