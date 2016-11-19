using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowPoints : MonoBehaviour {

    public float time;
    private Text text;
    private SpriteRenderer sprite;

    public Sprite plus5;
    public Sprite plus10;

	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (sprite.color.a > 0)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, sprite.color.a - .05f);
        }
        if (time <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void ShowPointsPop(int points)
    {
        sprite = GetComponent<SpriteRenderer>();

        if (points == 10)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1);
            sprite.sprite = plus10;
        }
        else if (points == 5)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1);
            sprite.sprite = plus5;            
        }
        else {
            sprite.color = new Color(0, 0, 0, 0);
        }
    }


}
