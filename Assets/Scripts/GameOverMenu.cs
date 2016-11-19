using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }
}
