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
				honeey = GameObject.Find("honey");
				Destroy(honeey);

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("player").transform.Find("gun_grab");

				print("�� ȹ��");
				cube.gameObject.SetActive(true);

			}

			if (other.gameObject.name == "honey")
            {
				ggun = GameObject.Find("gun");
				Destroy(ggun);

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("player").transform.Find("honey_grab");
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
			Debug.Log("GameOver");
			//StopAllCoroutines();
			Destroy(gameObject);
			obj1 = GameObject.Find("Canvas");
			obj1.GetComponent<GameOverMenu>().Show();
		}

	}

}
