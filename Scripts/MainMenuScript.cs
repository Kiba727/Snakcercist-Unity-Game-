using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");   
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
