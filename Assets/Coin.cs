using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("arconsis-logo");

        gameObject.transform.position = new Vector3(14, 5, 0);
        gameObject.AddComponent<BoxCollider2D>().size = new Vector2(3,3);
    }
}
