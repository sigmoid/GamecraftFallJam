using UnityEngine;
using System.Collections;

public class ItemCollision : MonoBehaviour {

    public int points;
    public int damage;

    public GameObject scorePop;
    public AudioClip CollectSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameController.Game.AudioPlayer.PlayOneShot(CollectSound);
            GameController.Game.AddPoints(points);
            GameController.Game.SubtractLives(damage);
            GameObject oth = Instantiate(scorePop, new Vector3(transform.position.x, transform.position.y, transform.position.z-3), new Quaternion()) as GameObject;
            oth.GetComponent<ShowPoints>().ShowPointsPop(points);
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
