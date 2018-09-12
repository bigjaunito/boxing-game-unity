using UnityEngine;
using System.Collections;

public class mouseLookScript01 : MonoBehaviour {

	public float lookSensetivety = 5f;
	public float xRotation;
	public float yRotation;
	public float currentXRotation;
	public float currentYRotation;
	public float xRotationV;
	public float yRotationV;
	public float lookSmoothDamp = 0.1f;







	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 xRotation -= Input.GetAxis ("Mouse Y") * lookSensetivety;
	 yRotation += Input.GetAxis ("Mouse X") * lookSensetivety;
	 
	 transform.rotation = Quaternion.Euler (xRotation, yRotation, 0);
	}
}
