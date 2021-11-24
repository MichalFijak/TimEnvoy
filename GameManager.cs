using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coins;
    public float pointCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        pointCount = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Update is called once per frame
    void Update()
    {
        pointCount = GameObject.FindGameObjectsWithTag("Coin").Length;

    }
}
