using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float MaxTimerTime;

    private Slider TimerSlider;

    private GameObject TimeOutCanvas;

    private GameObject PlayerCharacter;

    // Start is called before the first frame update
    void Start()
    {
        TimerSlider = GameObject.Find("TimerCountDown").GetComponent<Slider>();

        TimeOutCanvas = GameObject.Find("TimeOutCanvas");

        PlayerCharacter = GameObject.Find("PlayerCharacter");

        TimeOutCanvas.SetActive(false);

        TimerSlider.maxValue = MaxTimerTime;

        TimerSlider.value = MaxTimerTime;
    }

    // Update is called once per frame
    void Update()
    {
        //tid += Time.deltaTime;

        TimerSlider.value -= Time.deltaTime;
        
        if(TimerSlider.value == 0)
        {
            TimeOut();
        }
    }

    private void TimeOut()
    {
        
        //Time.timeScale = 0;

        TimeOutCanvas.SetActive(true);

        PlayerCharacter.SetActive(false);

    }

    public void ResetTimer()
    {
        TimerSlider.value = TimerSlider.maxValue;
    }
}
