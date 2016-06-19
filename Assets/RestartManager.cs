using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RestartYes(){
		SceneManager.LoadScene ("Main");
	}

	public void RestartNo(){
		SceneManager.LoadScene ("Start");
	}
}
