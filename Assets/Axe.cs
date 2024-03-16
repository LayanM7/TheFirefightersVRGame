using UnityEngine;

public class Axe : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the Axe touches an object with the tag "Door"
        if (other.CompareTag("Door"))
        {
            // Disable the collider of the door
            other.GetComponent<Collider>().enabled = false;
        }
    }
}

