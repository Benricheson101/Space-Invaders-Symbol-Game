using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCover : MonoBehaviour {
    // Use this for initialization
    float timestart;

    void OnEnable() {
        timestart = Time.time;
    }

    // Update is called once per frame
    void Update () {
        if(Time.time-5 >= timestart)
        {
            gameObject.SetActive(false);
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Alien"))
        {
            Destroy(gameObject);
        }
    }
}
