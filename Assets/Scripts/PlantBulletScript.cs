using UnityEngine;

public class PlantBulletScript : MonoBehaviour
{
    [Header("Componente links")]
    public Rigidbody2D Rb;

    [Header("Move")]
    public int side = 0;
    public float moveSpeed = 2f;


    void Update()
    {
        Move();
    }

    void Move()
    {
        Rb.linearVelocity = new Vector2(moveSpeed * side, Rb.linearVelocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DirectionTrigger"))
        {
            Destroy(gameObject);
        }
    }
}
