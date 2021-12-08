using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLvl : MonoBehaviour
{
    public bool nextLvl = false;
    public int pointCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pointCount = GameObject.FindGameObjectsWithTag("Coin").Length;
        

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((pointCount) <= 1 && other.CompareTag("Player"))
            
        {
            //Debug.Log("Point county " + pointCount);
            nextLvl=true;
        }
    }
}

