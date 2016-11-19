using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

    public GameObject HitEffect;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Instantiate(HitEffect, other.transform.position, Quaternion.identity);
        Destroy(other.gameObject);
    }
}
