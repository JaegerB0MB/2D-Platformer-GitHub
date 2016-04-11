using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	Canvas uiCanvas;
	public Toggle muteToggle;

	// Use this for initialization
	void Start () {
		uiCanvas = gameObject.GetComponent<Canvas> ();
		uiCanvas.enabled = false;

		if (PlayerPrefs.GetInt ("muteSound") >= 0) {
			if (PlayerPrefs.GetInt ("muteSound") == 1)
				muteToggle.isOn = true;
		}else{
			muteToggle.isOn = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			uiCanvas.enabled = !uiCanvas.enabled;
			// boolean can be either true or false;
		}
	}

	public void saveToggleState(){
		if (muteToggle.isOn) {
			PlayerPrefs.SetInt ("muteSound", 1);
		} else {
			PlayerPrefs.SetInt ("muteSound", 0);
		}
	}

}
