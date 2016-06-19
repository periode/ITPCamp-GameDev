using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SoundEffectManager : MonoBehaviour {

	public AudioClip ouch1;
	public AudioClip ouch2;
	public AudioClip ouch3;

	AudioSource player;

	GameManager gm;

	// Use this for initialization
	void Start () {
		player = GetComponent<AudioSource> ();
		gm = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){

		if(col.gameObject.tag == "Squid"){
			float r = Random.value;

			if(r < 0.3f){
				player.clip = ouch1;
			}else if(r < 0.6f){
				player.clip = ouch2;
			}else{
				player.clip = ouch3;
			}

			player.Play ();


			gm.score++;
			gm.scoreText.text = "times hit by squids: " + gm.score;
		}
	}


	void OnTriggerEnter(Collider col){
		SceneManager.LoadScene ("Victory");
	}
}
