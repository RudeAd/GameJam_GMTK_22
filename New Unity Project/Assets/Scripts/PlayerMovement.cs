 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed = 1;

    bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            if(isGrounded == true)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            }
        }
        else if (Input.GetKey("a"))
        {
            transform.position = transform.position + new Vector3((-MovementSpeed) * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKeyDown("s"))
        {

        }
        else if (Input.GetKey("d"))
        {
            transform.position = transform.position + new Vector3(MovementSpeed * Time.deltaTime, 0, 0);
        }
        //else if (Input.GetKeyDown(KeyCode.Space))
    }

    //make sure u replace "floor" with your gameobject name.on which player is standing
    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.name == "Block_Blue_1")
        {
            isGrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.name == "Block_Blue_1")
        {
            isGrounded = false;
        }
    }
}
