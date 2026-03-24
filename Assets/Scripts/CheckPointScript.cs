   using UnityEngine;

public class CheckPointScript : MonoBehaviour
{
    [Header("Component links")]
    public Animator anim;

    [HideInInspector] public bool isFlagPassed = false;

    float timer = 0;
    float timing = 1.2f;

    public void Update()
    {
        if(isFlagPassed)
        {
            if (timer >= timing)
            {
                anim.SetBool("isIdle", isFlagPassed);
            }
            timer += Time.deltaTime;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isFlagPassed = true;
            anim.SetBool("isPassed", isFlagPassed);
        }
    }
}
