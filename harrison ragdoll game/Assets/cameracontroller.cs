using UnityEngine;
using System.Collections;

public class cameracontroller : MonoBehaviour {

	public float lookSensetivety = 5f;
	public float xRotation;
	public float yRotation;
	public float currentXRotation;
	public float currentYRotation;
	public float xRotationV;
	public float yRotationV;
	public float lookSmoothDamp = 0.1f;







	void Start () {
		Screen.lockCursor = true;
		Cursor.visible = false;
	}

	// Update is called once per frame
	void Update () {
		xRotation -= Input.GetAxis ("Mouse Y") * lookSensetivety;
		yRotation += Input.GetAxis ("Mouse X") * lookSensetivety;

		transform.rotation = Quaternion.Euler (xRotation, yRotation, 0);


}
}




//using UnityEngine;
//using System;
//
//public class cameracontroller : MonoBehaviour {
//
//
//	public float minimumX = -70f;
//	public float maximumX = 70f;
//	public float minimumY = -360f;
//	public float maximumY = 360;
//
//	public float sensitivityX = 15f;
//	public float sensitivityY = 15f;
//
//	public Camera cam;
//	float rotationY = 0f;
//	float rotationX = 0f;
//
//	public GameObject player;
//	private	Vector3 offset;
//
//
//	void Start () 
//	{
//		offset = transform.position;
//	
//		Cursor.lockState = CursorLockMode.Locked;
//	}
//
//
//	void LateUpdate () 
//	{
//		transform.position = player.transform.position;
//		player.transform.RotateAround (transform.up, this.transform.rotation.eulerAngles.y - player.transform.eulerAngles.y);
//	}
//
//
//	void Update() {
//
//		rotationY += Input.GetAxis ("Mouse X") * sensitivityY;
//		rotationX += Input.GetAxis ("Mouse Y") * sensitivityX;
//
//		rotationX = Mathf.Clamp (rotationX, minimumX, maximumX);
//
//		transform.localEulerAngles = new Vector3 (0, rotationY, 0);
//		cam.transform.localEulerAngles = new Vector3 (-rotationX, rotationY, 0);
//	
//		if (Input.GetKey(KeyCode.Escape))
//		{
//			Cursor.lockState = CursorLockMode.None;
//			Cursor.visible = true;
//		}
//	}
////	void Start () {
////		Cursor.lockState = CursorLockMode.None;
////	
////
//	}







	


		

