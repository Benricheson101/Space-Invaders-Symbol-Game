using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "OtherBulletThing(Clone)" || collision.gameObject.name == "SpaceShip" || collision.gameObject.name == "_Ship")
        {
            print("Shield Power Activated!");
            Destroy(gameObject);
        }
        else
        {
            print("Hit by:" + collision.gameObject.name);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
