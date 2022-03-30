using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class Coin : MonoBehaviour
{
    void Start()
    {
        var spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("arconsis-logo");

        var boxCollider = gameObject.GetComponent<BoxCollider2D>();

        boxCollider.size = spriteRenderer.size;
        boxCollider.offset = spriteRenderer.sprite.bounds.center;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
