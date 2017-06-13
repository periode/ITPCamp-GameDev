using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeSquareBehaviour : MonoBehaviour {

	public float movementSpeed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//if the user is pressing the W key
		if(Input.GetKey(KeyCode.W)){
			this.transform.Translate (Vector3.forward * movementSpeed);
		}

		if(Input.GetKey(KeyCode.S)){
			this.transform.Translate (Vector3.back * movementSpeed);
		}

		//if I press A go left
		if(Input.GetKey(KeyCode.A)){
			this.transform.Translate (Vector3.left * movementSpeed);
		}

		//if I press D go right
		if(Input.GetKey(KeyCode.D)){
			this.transform.Translate (Vector3.right * movementSpeed);
		}
	}

	void OnCollisionEnter(Collision other){
		other.gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
	}
}
