using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private GameManager gm;
    public GameObject Ground;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        rb = gameObject.AddComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        rb.gravityScale = 0;
        gameObject.AddComponent<Movement>();
        gameObject.AddComponent<TransformJump>();

        spriteRenderer.sprite = Resources.Load<Sprite>("player");
        var boxCollider = gameObject.AddComponent<BoxCollider2D>();

        boxCollider.size = spriteRenderer.size;
        boxCollider.offset = spriteRenderer.sprite.bounds.center;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Coin") {
            gm.points++;
        }
    }
}
