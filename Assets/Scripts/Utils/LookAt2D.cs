using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LookAt2D {

	

	public static Quaternion LookAt(Transform objective, Transform origin)
	{
		Vector3 diff = objective.position - origin.position;
		diff.Normalize();
 
		float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		return (Quaternion.Euler(0f, 0f, rot_z - 90));
	}
}
