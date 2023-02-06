using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Bird))]

public class BirdCollisionHandler : MonoBehaviour
{
    private Bird _bird;

    void Start()
    {
        _bird = GetComponent<Bird>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        _bird.Die();
    }
}
