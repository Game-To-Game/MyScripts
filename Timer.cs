using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float minutes;
    public float seconds;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds <= 0 && minutes > 0)
        {
            minutes -= 1;
            seconds = 60;
            
        }
        timerText.text = minutes.ToString() + ":" + seconds.ToString();
    }
}
