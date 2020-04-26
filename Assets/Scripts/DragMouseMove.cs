using UnityEngine;

public class DragMouseMove : MonoBehaviour
{

    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    private float moveSpeed = 150f;
    private SpriteRenderer spriteRenderer;

   private void Awake()
   {
        spriteRenderer = GetComponent<SpriteRenderer>();
   }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

        if (spriteRenderer != null)
        {
            if (mousePosition.x > rb.position.x)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;

            }
        }
    }
}
