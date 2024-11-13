using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float force;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("enter");
        collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity = (transform.position-collision.gameObject.transform.position).normalized*force;
    }
}
