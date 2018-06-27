using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {
    public SpriteRenderer sr;
    public int colorToShoot;
    public float Lastcolorchange;
    public float interval;
    public Sprite[] TypesOfAliens;
    public bool switching; 
    private float switchinginterval=1;
    private float lastswitch=0;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
            if (colorToShoot == 0) { sr.sprite = TypesOfAliens[0]; }
            if (colorToShoot == 1) { sr.sprite = TypesOfAliens[1]; }
            if (colorToShoot == 2) { sr.sprite = TypesOfAliens[2]; }
            if (colorToShoot == 3) { sr.sprite = TypesOfAliens[3]; }
            
        if(switching == true)
        {
            if (Time.time - switchinginterval >= lastswitch)
            {
                switching = false;
            }
        }
    


        if (Time.time - interval >= Lastcolorchange)
        {
            colorToShoot = Random.Range(0, 4);

            //check the trigger for selected color and destroy them
            //AlienMovement.EliminatePastEnemies();
            switching = true;
            Lastcolorchange = Time.time;
            lastswitch = Time.time;
        }
    }
}
