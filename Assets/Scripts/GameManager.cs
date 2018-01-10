using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private GameObject[] noodles;

	public int noodlesCount = 5;
	public float noodlesDistance = 0.75f;

	public GameObject noodle;

	// Use this for initialization
	void Start () {
		//don't forget to initialize array first
		noodles = new GameObject[noodlesCount];
		Vector3 temp = transform.position;

		for (int i = 0; i < noodlesCount; i++) {
			noodles [i] = Instantiate (noodle, temp, Quaternion.identity)as GameObject;
			noodles [i].transform.SetParent (transform);
			temp.y += noodlesDistance;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
