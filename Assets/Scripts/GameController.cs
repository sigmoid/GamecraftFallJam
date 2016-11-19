using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    private int score;
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
        Debug.Log("AddedPoints: " + points);
        Debug.Log("TotalPoints: " + score);
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
        Debug.Log("Lostalife: " + lives);
        Debug.Log("TotalLives: " + _lives);
    }

	// Use this for initialization
	void Start () {
        score = 0;

       
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
