using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beemove : MonoBehaviour
{
	public GameObject waypoint;
	public float speed = 2f;
	public GameObject player;

	public bool lemon = true;
	Vector3[] wayPointList;
	Vector3 targetWayPoint;

	int currentWayPoint = 0;

	void Start()
	{
		int count = waypoint.transform.childCount;
		wayPointList = new Vector3[count];
		for (int i = 0; i < count; i++)
		{
			wayPointList[i] = waypoint.transform.GetChild(i).transform.position;
		}
		targetWayPoint = wayPointList[0];

		//Invoke("SetCameraRig", 3f);
	}

	void SetCameraRig()
	{
		GameObject rig = GameObject.FindGameObjectWithTag("rig");
		rig.transform.position = new Vector3(0, 0, 0);
		rig.transform.SetParent(player.transform, false);
	}

	void Update()
	{

		if (lemon == true)
		{
			player.transform.forward = Vector3.RotateTowards(-player.transform.forward,
				targetWayPoint - player.transform.position, speed * Time.deltaTime, 0.0f);

			//y축으로 진행 방향은 무시함
			player.transform.forward = new Vector3(-player.transform.forward.x, 0, -player.transform.forward.z);

			float distance = Vector3.Distance(player.transform.position, targetWayPoint);
			print(distance);
			if (distance < 0.9f)
			{
				player.transform.position = Vector3.MoveTowards(player.transform.position, targetWayPoint,
				speed * Time.deltaTime);
				currentWayPoint++;
				targetWayPoint = wayPointList[currentWayPoint % wayPointList.Length];
				return;
			}
			player.transform.position = Vector3.MoveTowards(player.transform.position, targetWayPoint,
				speed * Time.deltaTime);
		}

	}
}
