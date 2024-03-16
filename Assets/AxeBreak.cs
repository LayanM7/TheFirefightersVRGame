using UnityEngine;

public class AxeBreak : MonoBehaviour
{
    public AudioClip collisionSound; // Assign the sound clip in the Unity Editor
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If AudioSource component is not present, add it
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = collisionSound;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves an object with the "Door" tag
        if (collision.gameObject.CompareTag("Door"))
        {
            // Play the collision sound
            audioSource.Play();
        }
    }
}
