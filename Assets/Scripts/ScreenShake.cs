using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Shake(float time, float amt)
    {
        StartCoroutine(ShakeRoutine(time, amt));
    }

    private IEnumerator ShakeRoutine(float time,float amt)
    {
        float Timer = time;

        Vector3 basePosition = transform.position;

        while (Timer > 0)
        {
            Timer -= Time.deltaTime;
            transform.position = basePosition + Random.insideUnitSphere * amt;
            yield return null;
        }
        transform.position = basePosition;
        yield break;
    }
}
