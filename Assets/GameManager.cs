using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Object waterLight;

	// Use this for initialization
	void Start () {
	
		for(int i = 0; i < 10; i++){
			GameObject.Instantiate (waterLight, new Vector3 (Random.Range (-200, 200), Random.Range (8, 10), Random.Range (-20, 20)), Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
