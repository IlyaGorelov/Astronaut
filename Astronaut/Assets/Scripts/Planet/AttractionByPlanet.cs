using UnityEngine;

public class AttractionByPlanet : MonoBehaviour
{
    public float force;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!PlayerController.isOnPlanet)
        {
        var rb = collision.gameObject.GetComponent<Rigidbody2D>();

        Vector2 dir = (transform.position - collision.gameObject.transform.position).normalized;

        rb.linearVelocity += dir*force*Time.deltaTime;

        }
    }
}
