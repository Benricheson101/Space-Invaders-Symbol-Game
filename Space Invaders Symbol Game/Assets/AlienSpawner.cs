using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour {
    public GameObject Alien;
    public float interval;
    private float LastAlien;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time-interval>=LastAlien)
        {
            Instantiate(Alien, transform.position, Quaternion.identity);
            LastAlien = Time.time;
        }
	}
}
