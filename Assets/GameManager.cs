using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Object waterLight;
	public int score = 0;
	public Text scoreText;
	public int squidCountDeathThresholdScore = 10;
	// Use this for initialization 


	void Start () {

		scoreText.text = "times hit by squids: " + score;
	
		for(int i = 0; i < 10; i++){
			GameObject.Instantiate (waterLight, new Vector3 (Random.Range (-200, 200), Random.Range (8, 10), Random.Range (-20, 20)), Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () {
	

		if(score > squidCountDeathThresholdScore){
			GameObject ground = GameObject.Find ("Ground");
			if(ground != null)
				ground.SetActive (false);
		}

		if(GameObject.Find("Player").transform.position.y < -50){
			SceneManager.LoadScene ("Restart");
		}
	}
}
