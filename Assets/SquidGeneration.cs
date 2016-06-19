using UnityEngine;
using System.Collections;

public class SquidGeneration : MonoBehaviour {

	public Object squid;

	// Use this for initialization
	void Start () {
	
		for(int i = 0; i < 1000; i++){
			GameObject.Instantiate (squid, new Vector3 (Random.Range (-100, 100), Random.Range (-100, 100), Random.Range (-100, 100)), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
