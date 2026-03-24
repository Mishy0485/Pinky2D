using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStarterMenuScript : MonoBehaviour
{
    public void GoBackToStarterMenu()
    {
        SceneManager.LoadScene("StarterScreen");
    }
}
