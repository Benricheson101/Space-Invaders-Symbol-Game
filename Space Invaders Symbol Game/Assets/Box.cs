using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {
    public SpriteRenderer sr;
    public int colorToShoot;
    public float Lastcolorchange;
    public float interval;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (colorToShoot==0) { sr.color = Color.white; }
        if (colorToShoot == 1) { sr.color = Color.yellow; }
        if (colorToShoot == 2) { sr.color = Color.green; }
        if (colorToShoot == 3) { sr.color = Color.red; }
        if (Time.time - interval >= Lastcolorchange)
        { colorToShoot = Random.Range(0, 4);
            Lastcolorchange = Time.time;
        }
    }
}
