using UnityEngine;

public class SetRandomSprite : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;

    private void OnEnable()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        int rand = Random.Range(0, sprites.Length);
        spriteRenderer.sprite = sprites[rand];
    }
}
