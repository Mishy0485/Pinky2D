using UnityEngine;

public class MushroomEnemyScript : MonoBehaviour
{
    [Header("Component links")]
    public Rigidbody2D Rb;

    [Header("Move")]
    public float moveSpeed = 3f;
    int side = -1;
    bool isFacingRight = true;
    
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    void FlipSprite()
    {
        isFacingRight = !isFacingRight;
        Vector3 ls = transform.localScale;
        ls.x *= -1;
        transform.localScale = ls;
    }

    void Move()
    {
        Rb.linearVelocity = new Vector2(moveSpeed * side, Rb.linearVelocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DirectionTrigger"))
        {
            FlipSprite();
            side *= -1;
        }
    }
}
