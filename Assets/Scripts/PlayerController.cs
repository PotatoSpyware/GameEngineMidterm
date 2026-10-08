using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpF;
    private bool grounded;
    private bool dir;
    private Rigidbody2D rb;
    private Collider2D col;
    [SerializeField] GameObject bubble;
    private GameObject tempProj;
    GameManager gm;

    private void Awake()
    {
        TryGetComponent<Rigidbody2D>(out rb);
        TryGetComponent<Collider2D>(out col);
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocityX = -speed;
            dir = false;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocityX = speed;
            dir = true;
        }
        else
        {
            rb.linearVelocityX = 0;
        }

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            rb.AddForceY(jumpF);
            grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ShootBubble();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }

        else if (collision.gameObject.tag == "Food")
        {
            Eat(collision.gameObject);
        }
    }

    private void Eat(GameObject food)
    {
        Food temp = food.GetComponent<Food>();
        gm.AddScore(temp.GetValue());
    }

    private void ShootBubble()
    {
        tempProj = Instantiate(bubble, transform);
        Bubble temp = tempProj.GetComponent<Bubble>();
        temp.SetDir(dir);
    }
}
