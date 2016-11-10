using UnityEngine;
using System.Collections;

public class CandyDestroyer : MonoBehaviour {

	public CandyHolder candyHolder;
	public int reward;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Candy") {

			candyHolder.AddCandy (reward);

			Destroy (other.gameObject);
		}
	}

	// Use this for initialization
	/*
	 * void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	*/
}
