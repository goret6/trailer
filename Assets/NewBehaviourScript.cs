using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float angleY = 5.0f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,angleY , 0);
	
	}
}
