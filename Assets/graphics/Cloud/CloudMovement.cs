using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 1.0f;
    private float leftBoundary = -10f;
    private float rightSpawnPoint = 10f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Respawn cloud when it leaves the screen
        if (transform.position.x < leftBoundary)
        {
            RespawnCloud();
        }
    }

    void RespawnCloud()
    {
        float randomHeight = Random.Range(2f, 5f);
        transform.position = new Vector3(rightSpawnPoint, randomHeight, transform.position.z);
    }
}
