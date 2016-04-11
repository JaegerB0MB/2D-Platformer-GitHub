using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

	//public Camera camera;
	public GameObject character;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = new Vector3 (character.transform.position.x, 0f, -1f);
		follow ();
	}


	void follow(){
		if (character.transform.position.y > 5f) {
			float yDiff = (character.transform.position.y / 2f);
			print (yDiff);
			gameObject.transform.position = new Vector3 (character.transform.position.x, yDiff, -1f);
		}

	}
}
