using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviour : MonoBehaviour {

	float randOff;

	// Use this for initialization
	void Start () {
		randOff = Random.Range (0, 100);
		this.GetComponent<Light> ().color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Light> ().intensity = Mathf.Cos (randOff + Time.time * 10f) * 9f;
	}
}
