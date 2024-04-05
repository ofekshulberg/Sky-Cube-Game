using UnityEngine;

public class EndTriger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter ()
    {
        gameManager.Completelevel();
    }
}
