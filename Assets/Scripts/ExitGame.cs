using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour {
    public void onStartButtonClick()
    { 
        SceneManager.LoadScene("MainGame");

    }
}
