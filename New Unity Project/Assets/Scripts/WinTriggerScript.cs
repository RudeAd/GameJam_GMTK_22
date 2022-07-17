using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTriggerScript : MonoBehaviour
{

    private GameObject WinCanvas;

    // Start is called before the first frame update
    void Start()
    {
        WinCanvas = GameObject.Find("WinCanvas");

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
            Debug.Log("Won");
        }
    }
}
