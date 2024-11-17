using System;
using UnityEngine;

public class AttractionByPlanet : MonoBehaviour
{
    public float force;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!PlayerController.isOnPlanet)
        {
        var rb = collision.gameObject.GetComponent<Rigidbody2D>();

        Vector2 dir = (transform.position - collision.transform.position).normalized;
            Debug.DrawLine(transform.position, collision.transform.position);
        rb.linearVelocity += dir*force*Time.deltaTime;

        }
    }

}
