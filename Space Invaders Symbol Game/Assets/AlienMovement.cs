using System.Collections;
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
    // Use this for initialization
    void Start () {
        ColorBox = GameObject.Find("Color Box").GetComponent<Box>();
        }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-transform.right * speed +( transform.up * Mathf.Sin(Time.time*frequency))*oscillation);
        
      }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Left" || collision.gameObject.name == "SpaceShip")
        {
            Destroy(gameObject);
        }
        else
        {
            if (ColorBox.colorToShoot == color&& ColorBox.switching==false)//the color is right 
            {
                
                Destroy(gameObject);
                //i have shot the correct alien here
            }
            else {
                Destroy(gameObject);
                //ive shot the wrong alien, and should loose a life
            }
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
    }
    public void EliminatePastEnemies()
    {
        Destroy(gameObject);
    }
}//end


