using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Alien : MonoBehaviour {
    public Box ColorBox;

	// Use this for initialization
	void Start () {
        ColorBox = GameObject.Find("Color Box").GetComponent<Box>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (col.gameobject)
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
