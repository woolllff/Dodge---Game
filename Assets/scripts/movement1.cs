using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1 : MonoBehaviour {

    public float movememtSpeed;
    private bool goLeft;
    private Vector3 speed;

	// Use this for initialization
	void Start ()
    {
        goLeft = true;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        speed.x = movememtSpeed * Time.deltaTime;
		if (goLeft)
        {
            if (transform.position.x >-5.5)
            {
                transform.position -=speed;
            }
            else
            {
                goLeft = false;
            }
        }
        else
        {
            if (transform.position.x <5.5)
            {
                transform.position += speed;
            }
            else
            {
                goLeft = true;
            }
        }
	}
}
