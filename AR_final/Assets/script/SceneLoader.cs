using UnityEngine;
using UnityEngine.SceneManagement;  // For scene management

public class SceneLoader : MonoBehaviour
{
    // Method to load Marker-based AR scene
    public void LoadMarkerBasedScene()
    {
        SceneManager.LoadScene("marker");
    }

    // Method to load Marker-less AR scene
    public void LoadMarkerLessScene()
    {
        SceneManager.LoadScene("marker_less");
    }
}
