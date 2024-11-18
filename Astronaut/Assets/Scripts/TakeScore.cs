using UnityEngine;

public class TakeScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerController pc))
        {
            collision.gameObject.GetComponentsInChildren<AudioSource>()[1].Play();
            ScoreState.score++;
            Destroy(gameObject);
        }
    }
}
