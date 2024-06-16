using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public float amplitude = 0.05f;
    public float frequency = 2f;

    private Vector3 startPos;
    private float tempVal;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        tempVal = startPos.y + amplitude * Mathf.Sin(Time.time * frequency);
        transform.localPosition = new Vector3(startPos.x, tempVal, startPos.z);
    }

}
