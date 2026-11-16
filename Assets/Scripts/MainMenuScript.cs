using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] GameObject OptionsMenu;

    public void enterLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
