
using UnityEngine;

public class playercollition : MonoBehaviour
{
    public playerscript movement;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag=="obstacle")
        {
            Debug.Log("we hit an obstacle!!");
            movement.enabled = false;
            FindObjectOfType<gameManager>().EndGame();
        }
    }

}
