// 3/21/2025 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using UnityEngine;

public class FloatUpDown : MonoBehaviour
{
    // Variables to control the speed and height of the floating motion
    public float floatSpeed = 2.0f;
    public float floatHeight = 0.5f;

    private Vector3 originalPosition;

    void Start()
    {
        // Store the original position of the GameObject
        originalPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new Y position using a sine wave
        float newY = originalPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // Apply the new position to the GameObject
        transform.position = new Vector3(originalPosition.x, newY, originalPosition.z);
    }
}