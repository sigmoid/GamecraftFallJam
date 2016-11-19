using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public float Interval;
    public Transform[] positions;
    public GameObject Acorn;
    public GameObject GoldenAcorn;
    public GameObject Bomb;

    private float Timer;

	// Use this for initialization
	void Start () {
        Timer = Interval;
	
	}
	
	// Update is called once per frame
	void Update () {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Timer = Interval;
            SpawnAcorns();
        }
	
	}

    void SpawnAcorns()
    {
        bool allBombs = true;
        GameObject BombInstance;
        for (int i = 0; i < positions.Length; i++) 
        {
            float randNum = Random.Range(0, 100);
            if (randNum < 33)
            {
                Instantiate(Acorn, positions[i].position, Quaternion.identity);
                allBombs = false;
            }
            else if (randNum < 50)
            {
                BombInstance = Instantiate(Bomb, positions[i].position, Quaternion.identity) as GameObject;
                if (allBombs == true && i == 2)
                {
                    Destroy(BombInstance);
                    Debug.Log("Destroyed Bombs");
                }
            }
            else if (randNum < 60)
            {
                Instantiate(GoldenAcorn,positions[i].position,Quaternion.identity);
            }
            else
            {
                allBombs = false;
            }
        }
    }
}
