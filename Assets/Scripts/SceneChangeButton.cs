using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeButton : MonoBehaviour
{
    public string sceneName; // Name of the scene to load

    public void OnButtonPress()
    {
        SceneManager.LoadScene(sceneName);
    }
}
