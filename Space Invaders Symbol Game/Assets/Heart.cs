using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("Hit by: " + collision.gameObject.name);
        if(collision.gameObject.CompareTag("UsedByPowerups"))
        {
            if(GameObject.Find("AlienSpawner"))
            { 
                if(AlienSpawner.Lives < 3)
                {
                AlienSpawner.Lives++;
                Debug.Log("Lives added");
                }
            Destroy(gameObject);
                Debug.Log("Heart Destroyed");
            }

            /*GameObject.Find("Alien Spawner").GetComponent<AlienSpawner>().Lives++;*/
        }
    }
}
