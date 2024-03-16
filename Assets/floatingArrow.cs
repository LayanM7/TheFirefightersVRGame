using UnityEngine;

public class floatingArrow : MonoBehaviour
{
    public float floatSpeed = 1.0f;
    public float floatHeight = 0.5f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Calculate the new Y position using a sine wave for floating effect
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // Update the object's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}

