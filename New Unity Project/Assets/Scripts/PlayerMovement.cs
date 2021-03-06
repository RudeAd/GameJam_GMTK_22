 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed = 1;

    bool isGrounded = true;

    public Timer timer;

    private AudioSource Jumpsound;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("TimerScriptHolder").GetComponent<Timer>();
        Jumpsound = GameObject.Find("JumpSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(isGrounded == true)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);

                Jumpsound.Play();

                timer.ResetTimer();

                isGrounded = false;
            }
        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3((-MovementSpeed) * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKeyDown("s") || Input.GetKey(KeyCode.DownArrow))
        {

        }
        else if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(MovementSpeed * Time.deltaTime, 0, 0);
        }
        //else if (Input.GetKeyDown(KeyCode.Space))
    }

    //make sure u replace "floor" with your gameobject name.on which player is standing
    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.tag == "Block")
        {
            isGrounded = true;
        }
    }
    
    /*
    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.tag == "Block")
        {
            isGrounded = false;
        }
    }
    */
}
