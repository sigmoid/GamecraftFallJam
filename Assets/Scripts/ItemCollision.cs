using UnityEngine;
using System.Collections;

public class ItemCollision : MonoBehaviour {

    public int points;
    public int damage;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameController.Game.AddPoints(points);
            GameController.Game.SubtractLives(damage);
            Destroy(gameObject);
        }        
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
