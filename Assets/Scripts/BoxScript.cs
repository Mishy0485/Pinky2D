using UnityEngine;

public class BoxScript : MonoBehaviour
{
    [Header("Component links")]
    public Rigidbody2D BoxRb;

    [Header("Script")]
    PersonaMoveScript personaScript;

    
    void Start()
    {
        personaScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PersonaMoveScript>();
    }

    private void FixedUpdate()
    {
        if (personaScript.isPushing)
        {
            Debug.Log("true pour moi");
            MoveBox();
        }
    }

    void MoveBox()
    {
        personaScript.speed = personaScript.pushSpeed;

        if (personaScript.transform.position.x < gameObject.transform.position.x)
        {
            BoxRb.linearVelocity = new Vector2(personaScript.speed, BoxRb.linearVelocity.y);
        }
        else
        {
            BoxRb.linearVelocity = new Vector2(-personaScript.speed, BoxRb.linearVelocity.y);
        }
    }
}
