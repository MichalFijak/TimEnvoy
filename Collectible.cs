using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player")&&gameObject.CompareTag("Coin"))
        {
            Destroy(gameObject);
            FindObjectOfType<PlayerController>().Score(1.0f);
        }
        if(other.gameObject.CompareTag("Player")&&gameObject.CompareTag("Time"))
        {
            Destroy(gameObject);
            FindObjectOfType<PlayerController>().TimeMachine(true);

        }
    }
}
