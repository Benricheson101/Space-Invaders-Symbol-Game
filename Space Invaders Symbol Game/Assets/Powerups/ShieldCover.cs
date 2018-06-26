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
        if(Time.time-4 >= timestart)
        {
            gameObject.SetActive(false);
        }
	}
}
