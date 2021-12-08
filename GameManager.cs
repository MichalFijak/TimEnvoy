using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coins;
    public int sceneIndex;
    public float pointCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        pointCount = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Update is called once per frame
    void Update()
    {
        pointCount = GameObject.FindGameObjectsWithTag("Coin").Length;

        if(FindObjectOfType<EndLvl>().nextLvl)
        {
            Debug.Log("next lvl loaded");
            SceneManager.LoadScene(sceneIndex + 1);
        }
    }
}
