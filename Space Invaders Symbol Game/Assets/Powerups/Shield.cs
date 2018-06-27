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
        shieldCover = GameObject.Find("Shield_Cover");
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Time.time>= spawnedTime)
        {

            shieldCover.transform.GetChild(0).gameObject.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("UsedByPowerups"))
        {
            print("Shield Power Activated!");
            Destroy(gameObject);
            hasShield = true;
            shieldCover.transform.GetChild(0).gameObject.SetActive(true);
            spawnedTime = Time.time;

        }
    }

}
