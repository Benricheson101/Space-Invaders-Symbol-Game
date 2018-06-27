using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour {
    public GameObject[] powerups;
    public float interval;
    private float LastPowerup;
    public float Left;
    public float Right;
    public float Top;
    public float Bottom;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - interval >= LastPowerup)
        {
            transform.position = new Vector2(Random.Range(Left, Right), Random.Range(Top, Bottom));
            int RandomAlineIndex = Random.Range(0, powerups.Length);
            Instantiate(powerups[RandomAlineIndex], transform.position, Quaternion.identity);
            LastPowerup = Time.time;
        }

    }
}
