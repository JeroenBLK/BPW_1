
using UnityEngine;
using UnityEngine.SceneManagement;

public class navScript : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
