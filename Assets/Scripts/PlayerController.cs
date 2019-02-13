using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Tooltip("Base of the barrel of the tank")]
    public Transform barrelBase;

    private Rigidbody2D rb; // Component that control the physics of the object

    private const float speed = 200f;
    private const float rotateSpeed = 3500f;

    // Called at the first frame
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Called once every frame
    private void Update()
    {
        // Axis are parametered in Edit --> Project Settings --> Input
        float forward = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        // We move the tank
        rb.velocity = transform.up * forward * Time.deltaTime * speed;
        rb.angularVelocity = -horizontal * Time.deltaTime * rotateSpeed;
    }
}
