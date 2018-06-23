using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject Bullet;
    public float speed = 0.2f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector2.left * speed);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(-Vector2.left * speed);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector2.up * speed);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(-Vector2.up * speed);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 0, 3);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 0, -3);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector2.up * speed);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(-Vector2.up * speed);
        }
        if (Input.GetKeyDown("space"))
        {
            print("You hit space!");
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }
}