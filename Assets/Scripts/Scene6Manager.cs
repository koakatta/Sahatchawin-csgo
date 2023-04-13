using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene6Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if (!PlayerPrefs.HasKey("DedCount"))
        {
            PlayerPrefs.SetInt("DedCount", 0);
        }
        PlayerPrefs.SetString("Scene", SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToScene7() {
        SceneManager.LoadScene("Scene7");
    }
}
