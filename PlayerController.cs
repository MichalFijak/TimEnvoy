using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRb;
    bool playerGrounded;
    bool gotTimeMachine;
    public float jumpForce = 5.0f;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        gotTimeMachine = false;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        
        playerRb.velocity = new Vector2(horizontal * speed, playerRb.velocity.y);
        
        if(Input.GetKeyDown("space")&&playerGrounded)
        {
            playerGrounded = false;
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor")) { playerGrounded = true; }
    
        if (other.gameObject.CompareTag("Coin")) 
        { 
            Destroy(other.gameObject);
            Debug.Log("Piniondz!");
        }
        if (other.gameObject.CompareTag("Time"))
        {
            Destroy(other.gameObject);
            Debug.Log("Lets hack time!");
            gotTimeMachine = true;
        }
    }
}
