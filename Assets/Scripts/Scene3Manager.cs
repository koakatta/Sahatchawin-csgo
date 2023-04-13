using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3Manager : MonoBehaviour
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

    public void GoToScene4()
    {
        SceneManager.LoadScene("Scene4");
    }
}
