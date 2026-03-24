using Unity.VisualScripting;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public float followSpeed = 1f;
    public float yOffset = 1f;
    public float xOffset = 1f;
    /*public float maxX = 1f;
    public float maxY = 1f;*/
    public Transform player;

    public void FollowPlayer()
    {
        new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, -10f);
        Vector3 newPos = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed /* Time.deltaTime*/);
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }
}
