using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;
    public float force = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("shoot!");
            ShootBall();
        }
    }

    void ShootBall()
    {

        GameObject ball = Instantiate(
            ballPrefab,
            spawnPoint.position,
            spawnPoint.rotation
        );
        

        Rigidbody rb = ball.GetComponent<Rigidbody>();

        if (rb != null)
        {
           rb.AddForce(
                spawnPoint.forward * force,
                ForceMode.Impulse
            );
        }
    }
}