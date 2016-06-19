using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject targetCharacter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (targetCharacter.transform);
	}
}
