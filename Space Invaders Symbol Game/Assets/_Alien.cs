using System.Collections;
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
        if (collision.gameObject.name == "Left" || collision.gameObject.name == "_Ship" || collision.gameObject.name == "Shield-Cover_Child" || collision.gameObject.name == "Right" || collision.gameObject.name == "Top" || collision.gameObject.name == "Bottom")
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
