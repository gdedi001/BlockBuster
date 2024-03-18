using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour
{
    // Static instance of the SceneSwitcher that allows it to be accessed by any other script.
    public static GameStart Instance { get; private set; }
    // Name of the scene you want to load
    [SerializeField]
    private string sceneToLoad = "BlockBuster";

    private void Awake()
    {
        // Check if instance already exists
        if (Instance == null)
        {
            // if not, set instance to this
            Instance = this;
            // Optionally: Makes the object not be destroyed automatically when loading a new scene.
            //DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            // If instance already exists and it's not this, then destroy this to enforce the singleton.
            Destroy(gameObject);
        }
    }

    // This method will be called when the start button is pressed
    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneToLoad);
        /*
        // Check if the scene exists before loading
        if (Application.LoadLevel(sceneToLoad))
        {
            
        }
        else
        {
            Debug.LogWarning("Scene " + sceneToLoad + " cannot be loaded. Check if it exists and is added to the build settings.");
        }*/
    }
}
