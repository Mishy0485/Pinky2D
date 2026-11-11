using UnityEngine;
using UnityEngine.SceneManagement;


public class OpenLastMenu : MonoBehaviour
{
    [SerializeField] GameObject winScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // screen win : string + BtnToLobby + BtnExit
        winScreen.SetActive(true);
    }

    public void BackToLobby()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        if(UnityEditor.EditorApplication.isPlaying)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else Application.Quit(); 
    }
}
