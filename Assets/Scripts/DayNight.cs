using UnityEngine;

public class DayNight : MonoBehaviour
{
    public Light sun;
    public Material skyboxMat;
    public float speed = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 50f;
        else
            speed = 10f;

        sun.transform.Rotate(Vector3.right,
                             speed * Time.deltaTime);

        float t = Mathf.PingPong(Time.time * 0.05f, 1);

        sun.color = Color.Lerp(
            new Color(1f, 0.5f, 0.2f), 
            Color.white,
            t);

        skyboxMat.SetColor(
            "_SkyTint",
            Color.Lerp(
                new Color(1f, 0.5f, 0.2f), 
                Color.blue,               
                t));

        DynamicGI.UpdateEnvironment();
    }
}
