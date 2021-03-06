﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour {
    public float speed = 1;
    public int color;
    public Box ColorBox;
    // public bool colorismatched;
    public float oscillation = 1f;
    public float gracePeriod = 1.5f;
    public float frequency = 1f;
    public Ship ship;
    // Use this for initialization
    void Start()
    {
        ColorBox = GameObject.Find("Color Box").GetComponent<Box>();
        ship = GameObject.Find("SpaceShip").GetComponent<Ship>();
    }


	
	// Update is called once per frame
	void Update () {
        transform.Translate(-transform.right * speed +( transform.up * Mathf.Sin(Time.time*frequency))*oscillation);
        
      }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (/*collision.gameObject.name == "Left" ||*/ collision.gameObject.name == "SpaceShip" || collision.gameObject.name == "Shield-Cover_Child")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Bullet")
        {
            if (GetComponent<SpriteRenderer>().sprite == GameObject.Find("Color Box").GetComponent<SpriteRenderer>().sprite)
            {
                GameObject.Find("AlienSpawner").SendMessage("AddScore"); Debug.Log("Score is added");
            }
            else
            {
                Debug.Log("Wrong Ship Shot");
                ship.StartCoroutine(ship.Dontshoot());
            }
                Destroy(gameObject);
        }

       
        //This code destroyed UFOs when they hit powerups. Commented out for time being to fix.
        /* else
        {
            if (ColorBox.colorToShoot == color&& ColorBox.switching==false)//the color is right 
            {
                if (collision.gameObject.name == "SpaceShip")
                    Destroy(gameObject);
                //i have shot the correct alien here
            }
            else {
                Destroy(gameObject);
                //ive shot the wrong alien, and should loose a life
            }*/
        if (collision.gameObject.name == "Earthcollider")
            {
                if (GetComponent<SpriteRenderer>().sprite == GameObject.Find("Color Box").GetComponent<SpriteRenderer>().sprite && ColorBox.switching == false)
                {
                    //the bad alien has hit the planet and i should remove a life

                    GameObject.Find("AlienSpawner").SendMessage("RemoveLife");
                }
                else
                {
                    // a good alien has hit the planet
                    GameObject.Find("AlienSpawner").SendMessage("AddScore");

                }
                Destroy(gameObject);
            }
           

          
        }
    /*
    void Dontshoot()
    {
        Ship.canshoot = true;
        Debug.Log("it works");
    }*/
    
    public void EliminatePastEnemies()
    {
        Destroy(gameObject);
    }
}//end


