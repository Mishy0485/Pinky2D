using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{   
    public GameObject OptionsMenu;

    public void enterLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void enterOptionsMenu()
    {
        OptionsMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
