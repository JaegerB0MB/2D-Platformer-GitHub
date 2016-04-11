using UnityEngine;
using System.Collections;

public class switchCharacter : MonoBehaviour {

	public GameObject human;
	public GameObject animal;
	public GameObject android;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		switchChar ();
	}

	void switchChar (){
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			StatsManager.character = StatsManager.charForm.human;
			//print (StatsManager.character);
		}
		if(Input.GetKeyDown(KeyCode.Alpha2)){
			StatsManager.character = StatsManager.charForm.animal;
			//print (StatsManager.character);
		}
		if(Input.GetKeyDown(KeyCode.Alpha3)){
			StatsManager.character = StatsManager.charForm.android;
			//print (StatsManager.character);
		}

		switch (StatsManager.character) {
		case StatsManager.charForm.human:
			human.SetActive (true);
			animal.SetActive (false);
			android.SetActive (false);
			break;
		case StatsManager.charForm.animal:
			human.SetActive (false);
			animal.SetActive (true);
			android.SetActive (false);
			break;
		case StatsManager.charForm.android:
			human.SetActive (false);
			animal.SetActive (false);
			android.SetActive (true);
			break;
		default:
	
			break;
		}

        //GameObject.Find("Your_Name_Here").transform.position;

    }
}
