using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeAns : MonoBehaviour
{
     public string sceneName;
     void OnMouseDown()
     {
         Destroy(gameObject);
         SceneManager.LoadScene(sceneName);
     }
}
