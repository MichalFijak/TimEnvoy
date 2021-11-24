using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRb;
    public Points pointBar;
    public TimeMachine timeMachine;

    // Some bools for jumping and using TimeHacking!
    bool playerGrounded;
    [SerializeField] private bool gotTimeMachine;

    public float jumpForce = 5.0f;
    public float speed = 5.0f;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        gotTimeMachine = false;
        pointBar.SetPoints(score);

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        // basic movin left and right
        float horizontal = Input.GetAxis("Horizontal");
        
        //velocity
        playerRb.velocity = new Vector2(horizontal * speed, playerRb.velocity.y);
        

        // JUMP!
        if(Input.GetKeyDown("space")&&playerGrounded)
        {
            playerGrounded = false;
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
        }

        //Use time machine!
        if(gotTimeMachine)
        {
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                timeMachine.StartRewind();
            }
            if(Input.GetKeyUp(KeyCode.LeftShift))
            {
                timeMachine.StopRewind();
            }
        }
    }
    //check if we are grounded (yeap, we gonna jump like Prince of Persia)
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor")) { playerGrounded = true; }

        
    }


    public void Score(float score)
    {
        
        pointBar.SetPoints(score);
        
    }
    public void TimeMachine(bool nGotTimeMachine)
    {
        gotTimeMachine = nGotTimeMachine;
        // Msg "Lets Hack a time!!
    }


}
