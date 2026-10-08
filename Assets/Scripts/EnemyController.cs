using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private bool bubble;
    private bool dir;
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Collider2D col;
    [SerializeField] GameObject food;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TryGetComponent<Rigidbody2D>(out rb);
        TryGetComponent<Collider2D>(out col);
    }

    // Update is called once per frame
    void Update()
    {
        if (!bubble)
        {
            if (dir)
            {
                rb.linearVelocityX = speed;
            }
            else
            {
                rb.linearVelocityX = -speed;
            }
        }
        else
        {
            rb.linearVelocityX = 0;
            rb.linearVelocityY = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            dir = !dir;
        }

        if (collision.gameObject.tag == "Bubble")
        {
            Bubbled();
        }

        if (bubble && collision.gameObject.tag == "Player")
        {
            Die();
        }
    }

    private void Bubbled()
    {
        bubble = true;
    }

    private void Die()
    {
        Instantiate(food, transform);
        Destroy(gameObject);
    }
}
