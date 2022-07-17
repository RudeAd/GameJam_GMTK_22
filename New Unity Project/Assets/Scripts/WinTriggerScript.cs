using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTriggerScript : MonoBehaviour
{

    private GameObject WinCanvas;

    private GameObject PlayerCharacter;
    private GameObject TimerSlider;
    public GameObject BGAudio;

    // Start is called before the first frame update
    void Start()
    {
        WinCanvas = GameObject.Find("WinCanvas");
        PlayerCharacter = GameObject.Find("PlayerCharacter");
        TimerSlider = GameObject.Find("TimerCanvas");
        //BGAudio = GameObject.Find("BGAudio");

        WinCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            BGAudio.SetActive(false);
            WinCanvas.SetActive(true);
            //Time.timeScale = 0;
            TimerSlider.SetActive(false);
            PlayerCharacter.SetActive(false);
            //BGAudio.SetActive(false);
        }
    }
}
