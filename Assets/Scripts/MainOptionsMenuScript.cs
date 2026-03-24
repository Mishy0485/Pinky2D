using UnityEngine;

public class MainOptionsMenuScript : MonoBehaviour
{
    public GameObject MainMenu;

    public void closeOptionsMenu()
    {
        MainMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
