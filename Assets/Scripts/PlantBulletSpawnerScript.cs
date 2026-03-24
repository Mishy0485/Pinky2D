using UnityEngine;

public class PlantBulletSpawnerScript : MonoBehaviour
{
    [Header("GameObject")]
    public GameObject Bullet;

    [Header("Timer")]
    [SerializeField] float timing = 2f;
    float timer = 0f;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        if (timer >= timing)
        {
            Spawn();
            timer = 0f;
        }
        timer += Time.deltaTime;
    }

    void Spawn()
    {
        Instantiate(Bullet,transform.position, transform.rotation);
    }
}
