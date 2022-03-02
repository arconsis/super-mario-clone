using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class Coin : MonoBehaviour
{
    void Start()
    {
        gameObject.transform.position = new Vector3(14, -2.5f, 0);

        var spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("arconsis-logo");

        var boxCollider = gameObject.GetComponent<BoxCollider2D>();
        boxCollider.size = new Vector2(3,3);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
