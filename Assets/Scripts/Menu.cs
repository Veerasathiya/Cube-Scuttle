using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string Level = "Main Scene";

    public SceneFader sceneFader;
    public void StartGame()
    {
        sceneFader.FadeTo(Level);
    }
   
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
