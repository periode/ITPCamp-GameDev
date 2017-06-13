using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancerBehaviour : MonoBehaviour {

	public float bopAmount;
	float randomOffset;
	public float randomMovement;

	// Use this for initialization
	void Start () {
		randomOffset = Random.Range (0, 100);
	}
	
	// Update is called once per frame
	void Update () {

		//have a cosine give us an up/down movement
		float bopHeight = Mathf.Cos (randomOffset + Time.time * bopAmount) * 3f;

		//give that cosine to translate in order to move the dancer
//		this.transform.Translate (new Vector3 (0, bopHeight, 0));

		Vector3 newScale = new Vector3 (1, bopHeight, 1);
		this.transform.localScale = newScale;

		this.transform.Translate (new Vector3 (Random.Range (-randomMovement, randomMovement), 0, Random.Range (-randomMovement, randomMovement)));
	}
}
