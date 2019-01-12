
using UnityEngine;

public class trig : MonoBehaviour {

    public gameManager game;
    private void OnTriggerEnter()
    {
        game.completeLevel();
    }
}
