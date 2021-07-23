using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    public GameObject completeLevel;
    public GameObject exitButton;

    public void CompleteUI()
    {
        exitButton.SetActive(false);
        completeLevel.SetActive(true);
    }

    public void EndGame()
    {
        Debug.Log("GameOver");
        Invoke("Restart", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
