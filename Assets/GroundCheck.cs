using UnityEngine;
public class GroundCheck : MonoBehaviour
{
    public bool isGrounded;
    public float offset = 0.01f;
    private Vector2 colliderSize;
    private void Start()
    {
        colliderSize = gameObject.GetComponent<BoxCollider2D>().size;

        
    }

    private void Update()
    {
        Vector2 point = transform.position + Vector3.down * offset;
        isGrounded = Physics2D.OverlapBox(point, colliderSize, 0, LayerMask.GetMask("Obstacle"));
    }
}