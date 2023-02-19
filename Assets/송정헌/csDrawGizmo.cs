using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csDrawGizmo : MonoBehaviour
{
	void OnDrawGizmos()
	{
		int count = transform.childCount;


		Vector3 pre = new Vector3(0,0,0);
		Vector3 pos;

		for(int i = 0; i < count; i++) {
			
			Gizmos.color = i == 0 ? Color.red :Color.yellow;   

			pos = transform.GetChild (i).transform.position;

			Gizmos.DrawWireSphere(pos, 0.7f);
			if ( i > 0 ) Gizmos.DrawLine(pre, pos);
			pre = pos;
			
		}
	}
}
