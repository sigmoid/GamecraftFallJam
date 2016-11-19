using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public int score;
    public int _lives;

    public static GameController Game;

    void Awake()
    {

        if (Game!=null)
        {
            Destroy(this.gameObject);
            return; 
        }
        Game = this;
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
        _lives -= lives;
        if (_lives <= 0)
        {
            SceneManager.LoadScene("Game Over Screen");
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
