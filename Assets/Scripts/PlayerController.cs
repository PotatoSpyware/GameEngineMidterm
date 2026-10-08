using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Collider2D col;

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
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocityX = speed;
        }
        else
        {
            rb.linearVelocityX = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
