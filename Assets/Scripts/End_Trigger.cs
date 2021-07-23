using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Trigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteUI();
        
    }
}
