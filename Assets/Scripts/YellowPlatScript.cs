using UnityEngine;

public class YellowPlatScript : MonoBehaviour
{
    [Header ("Component links")]
    public Rigidbody2D Rb;
    public Animator anim;

    [Header("Fall")]
    public float gravityForce = 1f;
    public int deadZone = -30;

      
    bool isOnPlat;
    public float timeLapsPlat = 1f;
    float timer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnPlat) 
        {
            if (timer <= timeLapsPlat)
            {
                timer += Time.deltaTime;
            }
            else
            {
                Rb.linearVelocity = new Vector2(Rb.linearVelocity.x, Rb.linearVelocity.y - gravityForce);
                timer = 0;
            }
        }

        if (Rb.linearVelocity.y < deadZone)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        isOnPlat = true;
        anim.SetBool("isOnPlat", isOnPlat);
    }
}
