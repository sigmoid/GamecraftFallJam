using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Displayscore : MonoBehaviour {

    private Text scoredisplay;


	// Use this for initialization
	void Start () {
        scoredisplay = GetComponent<Text>(); 
	
	}
	
	// Update is called once per frame
	void Update () {
        scoredisplay.text = GameController.Game.score.ToString();
	}
}
