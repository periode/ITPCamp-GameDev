using UnityEngine;
using System.Collections;

public class SoundEffectManager : MonoBehaviour {

	public AudioClip ouch1;
	public AudioClip ouch2;
	public AudioClip ouch3;

	AudioSource player;

	// Use this for initialization
	void Start () {
		player = GetComponent<AudioSource> ();
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
		}


	}
}
