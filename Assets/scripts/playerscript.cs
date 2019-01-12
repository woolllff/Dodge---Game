using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour {

    public Rigidbody rb;
    public int forwardSpeed;
    public int sidewaysSpeed;
    private Vector3 fspeed;
    private Vector3 sspeed;

	// Update is called once per frame
	void FixedUpdate ()
    {
        fspeed.z = forwardSpeed * Time.deltaTime;
        sspeed.x = -sidewaysSpeed * Time.deltaTime;

        transform.position += fspeed;

        if (Input.GetKey("d"))
        {
            transform.position -= sspeed;
        }
        if (Input.GetKey("a"))
        {
            transform.position += sspeed;
        }
        if (transform.position.y < -1f)
        {
            FindObjectOfType<gameManager>().EndGame();
        }
	}
}
