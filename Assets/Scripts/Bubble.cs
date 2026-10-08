using UnityEngine;

public class Bubble : MonoBehaviour
{
    private bool dir;
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Collider2D col;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TryGetComponent<Rigidbody2D>(out rb);
        TryGetComponent<Collider2D>(out col);
    }

    // Update is called once per frame
    void Update()
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

    public void SetDir(bool d)
    {
        dir = d;
    }
}
