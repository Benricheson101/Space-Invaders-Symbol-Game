using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour {
    public float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-transform.right*speed);
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Left" || collision.gameObject.name == "SpaceShip")
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
} 

