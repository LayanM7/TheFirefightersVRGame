using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MissionAccomplished : MonoBehaviour
{
    public Image missionAccomplishedImage;
    public AudioClip missionAccomplishedSound;
    public float delayBeforeShowing = 5f;

    private bool missionCompleted = false;
    private AudioSource audioSource;

    void Start()
    {
        // Ensure the mission accomplished image is initially inactive
        if (missionAccomplishedImage != null)
        {
            missionAccomplishedImage.enabled = false;
        }

        // Get or add an AudioSource component to the GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider is tagged as "Axe" and the mission is not yet completed
        if (other.CompareTag("Axe") && !missionCompleted)
        {
            // Start the coroutine to show the mission accomplished image after a delay
            StartCoroutine(ShowMissionAccomplishedAfterDelay());

            // Play the mission accomplished sound
            if (audioSource != null && missionAccomplishedSound != null)
            {
                audioSource.PlayOneShot(missionAccomplishedSound);
            }
        }
    }

    IEnumerator ShowMissionAccomplishedAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delayBeforeShowing);

        // Set mission completed to true
        missionCompleted = true;

        // Show the mission accomplished image
        if (missionAccomplishedImage != null)
        {
            missionAccomplishedImage.enabled = true;
        }
    }
}
