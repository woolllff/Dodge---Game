using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instruction : MonoBehaviour {

    public GameObject instructions;
	// Use this for initialization
	void Start () {
        Invoke("close", 5);
	}
	
	void close()
    {
        instructions.SetActive(false);
    }
}
