using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playButton()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void levelsButton()
    {
        Debug.Log("under construction");
    }

    public void shopButton()
    {
        Debug.Log("under construction");
    }

    public void quitButton()
    {
        Application.Quit();
    }
}
