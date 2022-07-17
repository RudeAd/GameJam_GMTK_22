using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTriggerScript : MonoBehaviour
{

    private GameObject WinCanvas;

    private GameObject PlayerCharacter;
    private GameObject TimerSlider;
    // Start is called before the first frame update
    void Start()
    {
        WinCanvas = GameObject.Find("WinCanvas");
        PlayerCharacter = GameObject.Find("PLayerCharacter");
        TimerSlider = GameObject.Find("TimerCanvas");

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
            WinCanvas.SetActive(true);
            //Time.timeScale = 0;
            TimerSlider.SetActive(false);
            PlayerCharacter.SetActive(false);
        }
    }
}
