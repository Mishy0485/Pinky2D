using UnityEngine;

public class MelonScript : MonoBehaviour
{
    [Header("Component links")]
    public Animator anim;

    float timer = 0f;
    float timing = 1f;
    bool isCollected = false;

    void Update()
    {
        if(isCollected)
        { 
            if(timer >= timing)
            { 
                Destroy(gameObject);
            }
            timer += Time.deltaTime;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        isCollected = true;
        anim.SetTrigger("Collecting");
    }
}
