using UnityEngine;

public class HelloAR : MonoBehaviour
{
    // You can adjust this speed in the Unity Inspector
    public float rotationSpeed = 50f;

    void Update()
    {
        // Spins the cube around the Y-axis at a consistent speed on all phones
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}