using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene11Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("DedCount"))
        {
            PlayerPrefs.SetInt("DedCount", 0);
        }
        PlayerPrefs.SetString("Scene", SceneManager.GetActiveScene().name);
    }

    public void ExitTheGame()
    {
        Application.Quit();
    }
}
