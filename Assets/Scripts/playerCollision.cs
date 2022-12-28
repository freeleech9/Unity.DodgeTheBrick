
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public new Transform camera;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            
            GetComponent<playerMovement>().enabled= false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
