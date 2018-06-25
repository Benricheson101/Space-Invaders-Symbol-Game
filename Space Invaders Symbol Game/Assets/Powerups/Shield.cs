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
    //    private void OnCollisionEnter2D(Collision2D collision)
    //    {
    //        if (collision.gameObject.name == "SpaceShip" || //collision.gameObject.name == "OtherBulletThing(Clone)")
    //        {
    //            print("Shield Power Activated!");
    //            Destroy(gameObject);
    //        }
    //        else if (collision.gameObject.name == "Bullet")
    //        {
    //            print("You shot the shield with a normal bullet!");
    //        }
    //        else
    //        {
    //            print("?");
    //        }
    //    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "OtherBulletThing" || collision.gameObject.name == "SpaceShip")
        {
            print("Shield Power Activated!");
            Destroy(gameObject);
        }
        else
        {
            print("?");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
