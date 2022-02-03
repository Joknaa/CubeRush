
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

    public PlayerMovement Movement;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Movement.enabled = false;
        }
    }

 




    /*
    if(collisionInfo.collider.tag == "Obstacle")
    {
        Movement.enabled = false;
    }
    */

}

