﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Alien : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            print("oof");
        }
    }
}
