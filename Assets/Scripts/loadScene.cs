using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class loadScene : MonoBehaviour {
	// http://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
	// public static void LoadScene(int sceneBuildIndex, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);
	// public static void LoadScene(string sceneName, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);


	//public Scene firstScene;
	public string firstSceneName;
	public string secondSceneName;

	private Scene _currentLevel;

	void Start(){
		//_currentLevel = Scene.name;
		_currentLevel = SceneManager.GetActiveScene();
		print(_currentLevel.name);
	}
		
		
	public void loadFirstScene(){
		SceneManager.LoadScene(firstSceneName, LoadSceneMode.Single);
	}

	public void loadSecondScene(){
		SceneManager.LoadScene(secondSceneName, LoadSceneMode.Single);
	}

	public void reloadScene(){
		SceneManager.LoadScene(_currentLevel.name, LoadSceneMode.Single);
	}

	public void quitGame(){
		Application.Quit();
	}
}
