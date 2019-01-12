
using UnityEngine;

public class followplayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = player.position + offset;
	}
}
