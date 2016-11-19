using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public static float Speed = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Speed * Time.deltaTime * Vector3.down;
        transform.Rotate(Vector3.right * 50 * Time.deltaTime);
	}
}
