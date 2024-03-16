using UnityEngine;

public class Breakable : MonoBehaviour
{
    [SerializeField] GameObject intactMug;
    [SerializeField] GameObject brokenMug;

    BoxCollider bc;
   


    private void Awake()
    {
        intactMug.SetActive(true);
        brokenMug.SetActive(false);
        bc = GetComponent<BoxCollider>();
    }
   

        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Axe"))
        {
            
            Break();
         

        }
    }

    private void Break()
    {
        intactMug.SetActive(false);
        brokenMug.SetActive(true);

        // Assuming the door is tagged with "Door"
        GameObject door = GameObject.FindGameObjectWithTag("Door");

        if (door != null)
        {
            BoxCollider doorCollider = door.GetComponent<BoxCollider>();

            // Check if the door has a collider
            if (doorCollider != null)
            {
                // Disable the collider of the door
                doorCollider.enabled = false;
            }
            else
            {
                Debug.LogError("Door GameObject does not have a BoxCollider component.");
            }
        }
        else
        {
            Debug.LogError("No GameObject with the tag 'Door' found.");
        }
    }
}

