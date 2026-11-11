using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtonsScript : MonoBehaviour
{
    public void GoToTutorial()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene(4);
    }

    public void GoToLevel4()
    {
        SceneManager.LoadScene(5);
    }

    public void GoToLevel5()
    {
        SceneManager.LoadScene(6);
    }
}
