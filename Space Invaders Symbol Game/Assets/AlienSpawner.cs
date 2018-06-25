using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour {
    public GameObject[] Alien;
    public float interval;
    private float LastAlien;

    public float ScreenRight;
    public float ScreenLeft;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time-interval>=LastAlien)
        {
            transform.position = new Vector2( 11, Random.Range(ScreenLeft, ScreenRight));
        int RandomAlineIndex = Random.Range(0, 4);
            Instantiate(Alien[RandomAlineIndex], transform.position, Quaternion.identity);
            LastAlien = Time.time;
        }
	}
}
