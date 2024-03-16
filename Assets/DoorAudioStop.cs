using UnityEngine;

public class StopAudioOnCollision : MonoBehaviour
{
    // Reference to the AudioSource component
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Check if AudioSource component is present
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found on this GameObject.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding GameObject has the "Axe" tag
        if (collision.gameObject.CompareTag("Axe"))
        {
            // Stop the audio playback
            if (audioSource != null && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
