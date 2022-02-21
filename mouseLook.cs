using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{

	public float mouseSensitivity = 300f;
	public Transform playerBody;

	float xRotation = 0f;

	void Start()
    {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}


	void Update()
	{



		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
		// rotate player object around y-axis * movement of X
		playerBody.Rotate(Vector3.up * mouseX);
		// rotate player object around x-axis * movement of Y
		xRotation -= mouseY;
		//clamp xrotation to not be able to look behind player
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);
		transform.localRotation = Quaternion.Euler(xRotation,0f,0f);


		
	}
}