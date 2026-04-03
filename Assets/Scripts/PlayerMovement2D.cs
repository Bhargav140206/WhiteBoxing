using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    [Header("Speed Control")]
    public float speed = 6f; // 5–10
    public float minVelocity = 4f;
    public float maxVelocity = 7f;

    Rigidbody2D rb;
    Vector2 input;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 direction = input.normalized;

        float velocity = Mathf.Clamp(speed, minVelocity, maxVelocity);

        rb.velocity = direction * velocity;
    }
}
