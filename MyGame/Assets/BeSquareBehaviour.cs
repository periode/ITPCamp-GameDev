using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeSquareBehaviour : MonoBehaviour {

	public float movementSpeed = 0.5f;

	public Text score;

	int totalUndisturbedDancers = 10;

	// Use this for initialization
	void Start () {
		score.text = "undisturbed dancers: " + totalUndisturbedDancers;
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

		if(GameObject.Find("Speaker").GetComponent<AudioSource>().isPlaying){
			//the song is playing, try to survive!
		}else{
			//the song has finished playing
			SceneManager.LoadScene("Victory");
		}
	}

	void OnCollisionEnter(Collision other){

		if(other.gameObject.tag == "Dancer"){
			other.gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
			other.gameObject.GetComponent<AudioSource> ().pitch = Random.Range (0.6f, 1.4f);
			other.gameObject.GetComponent<AudioSource> ().Play ();

			//update the interface
			totalUndisturbedDancers -= 1;
			score.text = "undisturbed dancers: " + totalUndisturbedDancers;

			if(totalUndisturbedDancers == 0){
				SceneManager.LoadScene ("Restart");
			}
		}

	}
}
