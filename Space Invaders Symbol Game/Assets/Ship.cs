using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject Bullet;
    public float speed = 0.2f;
    public float RotationSpeed = 3f;
    public AudioSource laser;
    public  bool canshoot = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.position = new Vector2(transform.position.x + -speed, transform.position.y);
        }
        if (Input.GetKey("d"))
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        }
        if (Input.GetKey("w"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
        if (Input.GetKey("s"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + -speed);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 0, RotationSpeed);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 0, -RotationSpeed);
        }
        if (Input.GetKey("up"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
        if (Input.GetKey("down"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + -speed);
        }
        if (Input.GetKeyDown("space") && canshoot == true)
        {
            Instantiate(Bullet, transform.position, transform.rotation);
            laser.Play();
        }
        if (Input.GetKeyDown("r"))
        {
            transform.eulerAngles = new Vector3(0, 0, -90);
        }



    }

    public IEnumerator Dontshoot()
    {
        canshoot = false;
        yield return new WaitForSeconds(2.5f);
        canshoot = true;
        Debug.Log("it works");
    }



}
