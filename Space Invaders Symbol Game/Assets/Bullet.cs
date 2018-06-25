using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float BulletSpeed = 2f;
	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * BulletSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Top" || collision.gameObject.name == "Bottom" || collision.gameObject.name == "Left" || collision.gameObject.name == "Right")
        {
            Destroy(gameObject);
        }
    }

}
