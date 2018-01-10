using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {

	public float rotateSpeed = 20f;

	private float angle=1f;

	// Update is called once per frame
	void Update () {
		Rotate ();
	}

	void Rotate(){
		angle = transform.rotation.eulerAngles.z;
		angle += rotateSpeed * Time.deltaTime;
		transform.rotation = Quaternion.Euler (new Vector3(0,0,angle));
	}
}
