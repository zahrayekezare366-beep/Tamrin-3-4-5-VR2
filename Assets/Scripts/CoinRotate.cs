using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotateSpeed = 150f;
    public float floatSpeed = 2f;
    public float height = 0.2f;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0f, 0f);

        transform.position = startPos + Vector3.up * Mathf.Sin(Time.time * floatSpeed) * height;
    }
}