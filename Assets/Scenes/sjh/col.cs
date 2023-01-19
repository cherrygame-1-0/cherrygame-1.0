using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
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

			cube = GameObject.Find("mixamorig:RightHand").transform.Find("gun_grab");



			Destroy(other.gameObject);


			if (other.gameObject.name == "gun")
			{

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("mixamorig:RightHand").transform.Find("gun_grab");

				print("ÃÑ È¹µæ");
				cube.gameObject.SetActive(true);

			}

			if (other.gameObject.name == "honey")
            {

				cube.gameObject.SetActive(false);

				cube = GameObject.Find("mixamorig:RightHand").transform.Find("honey_grab");
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
			Destroy(gameObject);
		}


	}

}
