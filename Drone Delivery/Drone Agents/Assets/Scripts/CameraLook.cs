using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
	public float minX = -60f;
	public float maxX = 60f;

	public float sensitivity;
	public Camera cam;

	float rotY = 0f;
	float rotX = 0f;

	void Start()
	{
		
	}

	void Update()
	{
		rotY += Input.GetAxis("Mouse X") * sensitivity;
		rotX += Input.GetAxis("Mouse Y") * sensitivity;

		transform.localEulerAngles = new Vector3(-rotX, rotY, 0);

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			//Mistake happened here vvvv
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}

		if (Input.GetMouseButtonDown(1))
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
	}
}