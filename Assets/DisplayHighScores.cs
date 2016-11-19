using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayHighScores : MonoBehaviour {
    private Text displayHighScore;
	// Use this for initialization
	void Start ()
    {
        displayHighScore = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        displayHighScore.text = "";
        displayHighScore.text += PlayerPrefs.GetInt("Score1") + "\n";
        displayHighScore.text += PlayerPrefs.GetInt("Score2") + "\n";
        displayHighScore.text += PlayerPrefs.GetInt("Score3") + "\n";
    }

    public static void compareScores()
    {
        int currentHighScore = GameController.Game.score;
        if (PlayerPrefs.GetInt("Score1") < currentHighScore)
        {
            PlayerPrefs.SetInt("Score3", PlayerPrefs.GetInt("Score2"));
            PlayerPrefs.SetInt("Score2", PlayerPrefs.GetInt("Score1"));
            PlayerPrefs.SetInt("Score1", currentHighScore);
        }
        else if (PlayerPrefs.GetInt("Score2") < currentHighScore)
        {
            PlayerPrefs.SetInt("Score3", PlayerPrefs.GetInt("Score2"));
            PlayerPrefs.SetInt("Score2", currentHighScore);
        }
        else if (PlayerPrefs.GetInt("Score3") < currentHighScore)
        {
            PlayerPrefs.SetInt("Score3", currentHighScore);
        }
    }
}
