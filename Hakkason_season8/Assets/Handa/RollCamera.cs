using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollCamera : MonoBehaviour
{
	public float fRotateSpeed = 10.0f;

	void Update()
	{
		bool isPush = true;

		if (isPush)
		{
			// 移動量
			float fValue = fRotateSpeed * Time.deltaTime;

			// 回転
			transform.Rotate(0, fValue, 0, Space.World);
		}
	}
}
