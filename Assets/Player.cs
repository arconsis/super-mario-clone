using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        gameObject.AddComponent<Movement>();

        spriteRenderer.sprite = Resources.Load<Sprite>("player");

        gameObject.AddComponent<BoxCollider2D>().size = new Vector2(3, 3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
