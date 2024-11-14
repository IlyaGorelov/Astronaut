using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField] float force;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.Mouse0)|| Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(transform.up * force, ForceMode2D.Impulse);
        }
    }
}
