using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour {
    public float speed = 1;
    public int color = 0;
    public Box ColorBox;

    // Use this for initialization
    void Start () {
        ColorBox = GameObject.Find("Color Box").GetComponent<Box>();
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
            if (ColorBox.colorToShoot == color)//the color is right 
            {
                //Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            else {//the color is wrongs
            }
            if (collision.gameObject.name == "Earthcollider")
            {
                if (GetComponent<SpriteRenderer>().color == GameObject.Find("Color Box").GetComponent<SpriteRenderer>().color)
                    print("color match");

                    GameObject.Find("Alien Spawner").SendMessage("RemoveLife");
                Destroy(gameObject);
            }
            else
            {
                //Destroy(collision.gameObject);
                Destroy(gameObject);
                GameObject.Find("Alien Spawner").SendMessage("AddScore");
            }
        }
    }
} 

