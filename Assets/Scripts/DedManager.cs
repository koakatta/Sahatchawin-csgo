using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DedManager : MonoBehaviour
{
    public TMP_Text dedCauseText;
    public TMP_Text dedCountText;
    public GameObject dedPanel;
    public AudioSource dedSoundTrack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ded(string cause) {
        if (!PlayerPrefs.HasKey("DedCount"))
        {
            PlayerPrefs.SetInt("DedCount", 0);
        }
        PlayerPrefs.SetInt("DedCount", PlayerPrefs.GetInt("DedCount")+1);
        dedCountText.SetText(PlayerPrefs.GetInt("DedCount").ToString());
        dedCauseText.SetText(cause);
        dedPanel.SetActive(true);
        dedSoundTrack.Play();
    }

    public void Reset() {
        SceneManager.LoadScene(PlayerPrefs.GetString("Scene"));
    }
}
