using UnityEngine;

public class ObstacleHealth : MonoBehaviour
{
    public int health = 5;

    public void TakeDamage()
    {
        health--;

        Debug.Log(gameObject.name + "hp=" + health);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}