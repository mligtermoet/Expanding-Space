
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    public GameObject Lose;
    public float startTime;
    public float endTime;

    void Start()
    {
        startTime = 595f;
        endTime = startTime - Time.time;
    }

    void Update()
    {
        float t = startTime - Time.time;

        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 59.5299).ToString("00");

        timerText.text = "Time: " + minutes + "." + seconds;

        if (endTime == 0)
        {
            bool isActive = Lose.activeSelf;

            Lose.SetActive(true);
        }
    }
}
