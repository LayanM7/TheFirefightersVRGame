using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChsnger : MonoBehaviour
{
    public string sceneToLoad;

    private void Start()
    {
        // Optional: You can set a default scene to load if needed
        if (string.IsNullOrEmpty(sceneToLoad))
        {
            Debug.LogError("Please specify a scene to load in the inspector.");
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
