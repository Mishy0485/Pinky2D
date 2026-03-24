using System.Collections;
using UnityEngine;

public class TrampolineScript : MonoBehaviour
{
    [Header("Component links")]
    public Animator anim;

    Rigidbody2D personaRb;

    [Header("Jump")]
    public float jumpForce = 10f;

    bool isOn = false;
    float timer = 0;
    float timing = .1f;

    public void Start()
    {
        personaRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isOn)
        {
            if (timer >= timing)
            {
                isOn = false;
                anim.SetBool("isOn", isOn);
                timer = 0;
            }
            timer += Time.deltaTime;
        }
    }

    public void Jump()
    {
        personaRb.linearVelocity = Vector2.up * jumpForce;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        isOn = true;
        anim.SetBool("isOn", isOn);
        Jump();
    }
}
