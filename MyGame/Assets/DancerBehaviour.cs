using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancerBehaviour : MonoBehaviour {

	public float bopAmount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//have a cosine give us an up/down movement
		float bopHeight = Mathf.Cos (Time.time * bopAmount) * 3f;

		//give that cosine to translate in order to move the dancer
//		this.transform.Translate (new Vector3 (0, bopHeight, 0));

		Vector3 newScale = new Vector3 (1, bopHeight, 1);
		this.transform.localScale = newScale;
	}
}
