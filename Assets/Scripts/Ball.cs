using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ball hit: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Player"))
            return;

        ObstacleHealth obstacle =
            collision.gameObject.GetComponent<ObstacleHealth>();

        if (obstacle != null)
        {
            obstacle.TakeDamage();
        }

        //Destroy(gameObject);
            void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ball hit: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Ground"))
            return;

        ObstacleHealth obstacle =
            collision.gameObject.GetComponent<ObstacleHealth>();

    if (obstacle != null)
    {
        obstacle.TakeDamage();
    }

    Destroy(gameObject);
    }
    }
}