using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject imageBSOD;
    public GameObject panelJustKidding;
    private int timerBSOD = 7;
    private bool timerBSODTriggered = false;
    private int timerExit = 3;
    private bool timerExitTriggered = false;
    private int timerJustKidding = 4;
    void Start()
    {
        if (!PlayerPrefs.HasKey("DedCount")) {
            PlayerPrefs.SetInt("DedCount", 0);
        }
        PlayerPrefs.SetString("Scene", SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToScene1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void ShowBSODInTime()
    {
        if (!timerBSODTriggered) {
            timerBSODTriggered = true;
            StartCoroutine(TimerIE());
        }
    }

    public void ExitTheGame() {
        if (!timerExitTriggered) {
            timerExitTriggered = true;
            StartCoroutine(TimerExitTheGame());
        }
    }

    IEnumerator TimerIE()
    {
        while (timerBSOD >= 0) {
            yield return new WaitForSeconds(1f);
            timerBSOD--;
        }
        imageBSOD.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        StartCoroutine(TimerJustKidding());
    }

    IEnumerator TimerExitTheGame()
    {
        while (timerExit >= 0) {
            yield return new WaitForSeconds(1f);
            timerExit--;
        }
        Application.Quit();
    }

    IEnumerator TimerJustKidding() {
        while (timerJustKidding >= 0) {
            yield return new WaitForSeconds(1f);
            timerJustKidding--;
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        panelJustKidding.SetActive(true);
    }
}
