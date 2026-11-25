using Unity.VisualScripting;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public float followSpeed = 1;
    public Transform player;
    private float lastPosY;
    public float JumpOffset = 5;

    [Header("Limites de la caméra")]
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = -5f;
    public float maxY = 5f;

    private void Start()
    {
        lastPosY = transform.position.y;
    }

    void Update()
    {  
        FollowPlayer();
    }

    public void FollowPlayer()
    {
        float targetX = player.transform.position.x;
        float targetY = player.transform.position.y;

        if (targetX > maxX) { targetX = maxX; }
        if (targetX < minX) { targetX = minX; }
        if(targetY > maxY) { targetY = maxY; }
        if (targetY < minY) { targetY = minY;}

        if(Mathf.Abs(lastPosY - targetY) <   JumpOffset)
        {
            targetY = lastPosY;
        }

        lastPosY = targetY;
        Vector3 newPos = new Vector3(targetX, targetY, -10f);
        transform.position = Vector3.Lerp(transform.position, newPos, followSpeed * Time.deltaTime);
    }
}
