using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroughShot : MonoBehaviour {
    public GameObject canHit;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Top" || collision.gameObject.name == "Bottom" || collision.gameObject.name == "Left" || collision.gameObject.name == "Right")
        {
            Destroy(gameObject);
        }
    }
}
