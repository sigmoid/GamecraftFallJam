using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public int score;
    public int _lives;

    public static GameController Game;

    public AudioSource AudioPlayer;

    void Awake()
    {

        if (Game!=null)
        {
            Destroy(this.gameObject);
            return; 
        }
        Game = this;

        AudioPlayer = GetComponent<AudioSource>();
    }

   public  void AddPoints(int points)
    {
        score += points;
    }

    public void SubtractPoints(int points)
    {
        score -= points;
    }

    public void AddLives(int lives)
    {
        _lives += lives;
    }

    public void SubtractLives(int lives)
    {
        if(lives!=0)
            Camera.main.GetComponent<ScreenShake>().Shake(.25f, .25f);

        _lives -= lives;
        if (_lives <= 0)
        {
            SceneManager.LoadScene("Game Over Screen");
            DisplayHighScores.compareScores();
        }

    }

	// Use this for initialization
	void Start () {
        score = 0;

       
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
