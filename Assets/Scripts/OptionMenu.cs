using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    public void OpenOptionMenu()
    {
        gameObject.SetActive(true);
    }

    public void closeMenu()
    {
        gameObject.SetActive(false);
    }
}
