using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayLives : MonoBehaviour {


    private Text Livesdisplay;


	// Use this for initialization
	void Start () {

        Livesdisplay = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Livesdisplay.text = "Lives: " + GameController.Game._lives.ToString(); 
	}
}
