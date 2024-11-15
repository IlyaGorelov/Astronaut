using UnityEngine;

public class SetActiveLoseScreen : MonoBehaviour
{
    [SerializeField] GameObject LoseScreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            LoseScreen.SetActive(true);
        }
    }
}
