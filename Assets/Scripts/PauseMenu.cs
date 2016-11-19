using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    private GameObject PausePanel;
    private float regTimeScale;

	// Use this for initialization
	void Start () {
        PausePanel = this.transform.GetChild(0).gameObject;
        regTimeScale = Time.timeScale;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bool isPaused = PausePanel.activeInHierarchy;
            if (isPaused == true)
            {
                PausePanel.SetActive(false);
                Time.timeScale = regTimeScale;
            }
            else
            {
                PausePanel.SetActive(true);
                regTimeScale = Time.timeScale;
                Time.timeScale = 0;
            }
        }
	
	}

    public void PressResume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = regTimeScale;
    }
}
