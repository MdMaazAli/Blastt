using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainWindowManager : MonoBehaviour
{
    [SerializeField] string SceneName;
    public void retryLevel()
    {
        SceneManager.LoadScene(SceneName);
    }
}
