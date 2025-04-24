using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 ballDirection;

    void Start()
    {
        ballDirection = Random.onUnitSphere;
        ballDirection.y = 0;
        ballDirection.Normalize();
    }

    void Update()
    {
        transform.position += ballDirection * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        ballDirection = Vector3.Reflect(ballDirection, contact.normal);
    }
}
