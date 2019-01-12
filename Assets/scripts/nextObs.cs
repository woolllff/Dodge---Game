
using UnityEngine;

public class nextObs : MonoBehaviour {

    public gameManager game;
    public GameObject currentObs;
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        currentObs.SetActive(false);
        game.activateNewObs();

    }

}
