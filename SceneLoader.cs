using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void GotoMenuScene()
    {
        SceneManager.LoadScene("menu");
    }

    public void GotoMainScene()
    {
        SceneManager.LoadScene("AR");
    }
}