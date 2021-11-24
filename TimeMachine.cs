using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMachine : MonoBehaviour
{
    private bool isRewind = false;

    List<Vector2> positions;

    private void Start()
    {
        positions = new List<Vector2>();
    }
    private void FixedUpdate()
    {
        if (isRewind)
        {
            Rewind();
        }
        else Record();
    }
    public void StartRewind()
    {
        isRewind = true;

    }
    public void StopRewind()
    {
        isRewind = false;

    }
    public void Record()
    {
        positions.Insert(0, transform.position);

    }
    void Rewind()
    {
        if (positions.Count > 0)
        {
            transform.position = positions[0];
            positions.RemoveAt(0);
        }
        else StopRewind();

    }
}
