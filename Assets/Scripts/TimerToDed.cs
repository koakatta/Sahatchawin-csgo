using UnityEngine;
using System;
using System.Collections;
using UnityEngine.Events;
using TMPro;


public class TimerToDed : MonoBehaviour
{
    public UnityEvent onDed;
    public float timer;
    public TMP_Text timerText;


    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.SetText(String.Concat("Time left: ", timer.ToString("f2")));
        }
        if (timer < 0)
        {
            timer = 0;
            onDed.Invoke();
        }

    }
}