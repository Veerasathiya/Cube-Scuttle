using UnityEngine;
using UnityEngine.SceneManagement;
public class GamePauseEx : MonoBehaviour
{

    public void Exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex.ToString("Menu Scene"));
    }
}
