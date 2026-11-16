using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameMenu : MonoBehaviour
{
    [SerializeField] GameObject InGameMenuOverview;
    [SerializeField] GameObject InGameOptionsMenu;
    [SerializeField] GameObject MenuButton;

    public void GoBackToStarterMenu()
    {
        SceneManager.LoadScene("StarterScreen");
    }

    public void OpenInGameMenuOverview()
    {
        InGameMenuOverview.SetActive(true);
    }

    public void OpenOptionMenuInGame()
    {
        InGameOptionsMenu.SetActive(true);
        MenuButton.SetActive(false);
    }

    public void AppplyMenuButton()
    {
        MenuButton.SetActive(true);
    }

    public void CloseInGameMenu()
    {
        InGameMenuOverview.SetActive(false);
    }
}
