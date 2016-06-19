using UnityEngine;
using System.Collections;

public class SquidBehaviour : MonoBehaviour {

	float rotationSpeed;
	float scaleFactor;

	// Use this for initialization
	void Start () {
		if(Random.value < 0.5f){
			rotationSpeed = Random.Range (0.9f, 3.5f);
		}else{
			rotationSpeed = Random.Range (-0.9f, -3.5f);
		}

		scaleFactor = Random.Range (0.9f, 3f);
		transform.localScale *= scaleFactor;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, rotationSpeed);
	}
}
