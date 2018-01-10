using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noodle : MonoBehaviour {

	[SerializeField]
	private GameObject noodleBody;

	private Rigidbody2D myBody;

	public float ShootSpeed = 2f;

	// Use this for initialization
	void Awake () {
		noodleBody.SetActive (false);
		myBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FireTheNoodle(){
		myBody.isKinematic = false;
		noodleBody.SetActive (true);
		myBody.velocity = new Vector2 (0,ShootSpeed);
	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag=="Circle") {
			myBody.isKinematic = true;
			gameObject.transform.SetParent (target.transform);
		}

	}
}
