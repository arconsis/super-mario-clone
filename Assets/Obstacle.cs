using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class Obstacle : MonoBehaviour
{
    // Use this for initialization
    void Awake()
    {
        var spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("obstacle");

        var boxCollider = gameObject.GetComponent<BoxCollider2D>();

        boxCollider.size = spriteRenderer.size;
        boxCollider.offset = spriteRenderer.sprite.bounds.center;
    }
}
