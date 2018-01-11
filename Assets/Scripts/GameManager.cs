using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//######################################################################
	private GameObject[] noodles;

	public GameManager instance;


	public int noodlesCount = 2;

	public float noodlesDistance = 0.75f;

	private int currentIndex=0;

	public GameObject noodle;

	// Use this for initialization
	void Awake () {
		CheckSingliton ();
	}

	// Use this for initialization
	void Start () {
		CreatePins ();

	}

	void CheckSingliton(){
		if (!instance) {
			instance = this;
		} else {
			Destroy (instance);
		}
	}

	void CreatePins(){
		//don't forget to initialize array first
		noodles = new GameObject[noodlesCount];
		Vector3 temp = transform.position;

		for (int i = 0; i < noodlesCount; i++) {
			noodles [i] = Instantiate (noodle, temp, Quaternion.identity) as GameObject;
			noodles [i].transform.SetParent (transform);
			temp.y -= noodlesDistance;
		}
	}


	public void ShootTheNeedle(){
		if (currentIndex<noodlesCount) {
			noodles [currentIndex].GetComponent<Noodle>().FireTheNoodle();
			currentIndex++;
		}

	}
}
