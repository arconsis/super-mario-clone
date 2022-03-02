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
        
        gameObject.AddComponent<Movement>();

        spriteRenderer.sprite = Resources.Load<Sprite>("player");
        gameObject.AddComponent<BoxCollider2D>().size = new Vector2(2, 4);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Coin") {
            gm.points++;
        }
    }
}
