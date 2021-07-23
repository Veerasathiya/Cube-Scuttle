using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public void GameLobby()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex.ToString("Menu Scene"));
    }

    public void Quit()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
