using UnityEngine;

public class TakeScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerController pc))
        {
            ScoreState.score++;
            Destroy(gameObject);
        }
    }
}
