using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    
    public Transform leftlane,  midlane, rightlane;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        PlayerMovement1();
        //PlayerMovement2();
	
	}

    void PlayerMovement1 () {

        var left = Input.GetKey(KeyCode.LeftArrow);
        var right = Input.GetKey(KeyCode.RightArrow);
        

        if (right)
        {
            transform.position = new Vector3(rightlane.position.x, transform.position.y, transform.position.z);

        }
        if (left)
        {
            transform.position = new Vector3(leftlane.position.x, transform.position.y, transform.position.z);
        }

        if (!right && !left)
        {
              transform.position = new Vector3(midlane.position.x, transform.position.y, transform.position.z);
        }


    }

    void PlayerMovement2()
    { }








    



}
