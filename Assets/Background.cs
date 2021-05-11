using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float moveSpeed = 1f;

    public float offset;

    private Vector2 startPosition;

    private float newXposition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        newXposition = Mathf.Repeat(Time.time * -moveSpeed, offset);

        transform.position = startPosition + Vector2.right * newXposition;
    }
}
