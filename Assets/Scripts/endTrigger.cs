using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}
