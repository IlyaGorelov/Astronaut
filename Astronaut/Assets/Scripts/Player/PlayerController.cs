using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField] float force;
    public static bool isOnPlanet;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (isOnPlanet)
            {
                rigidbody2D.AddForce(transform.up * force, ForceMode2D.Impulse);
                isOnPlanet = false;
                GetComponent<AudioSource>().Play();
                transform.SetParent(null);
            }
        }
    }

}
