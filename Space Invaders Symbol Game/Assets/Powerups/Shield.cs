using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {
    public static bool hasShield = false;
    public GameObject shieldCover;
    public float lengthOfTime = 2f;
    public float spawnedTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Time.time>= spawnedTime)
        {
            print("Here");
            shieldCover.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "OtherBulletThing(Clone)" || collision.gameObject.name == "SpaceShip" || collision.gameObject.name == "_Ship")
        {
            print("Shield Power Activated!");
            Destroy(gameObject);
            hasShield = true;
            shieldCover.SetActive(true);
            spawnedTime = Time.time;

        }
        else
        {
            print("Hit by:" + collision.gameObject.name);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
