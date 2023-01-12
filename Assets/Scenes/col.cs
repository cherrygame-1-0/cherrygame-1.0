using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
	private Transform cube;

	void Start()
    {
		print("start");
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

			}

			if (other.gameObject.name == "honey")
            {

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("player").transform.Find("honey_grab");
				print("²Ü È¹µæ");
				cube.gameObject.SetActive(true);
			}

		}

	}

}
