using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtonsScript : MonoBehaviour
{
    public void GoToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void GoToLevel4()
    {
        SceneManager.LoadScene("Level_3");
    }

    public void GoToLevel5()
    {
        SceneManager.LoadScene("Level_4");
    }
}
