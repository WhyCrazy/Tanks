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

        // Set barrel rotation to look at mouse
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Quaternion rot = barrelBase.transform.rotation;
        rot.SetFromToRotation(-Vector3.up, (mousePos - barrelBase.transform.position));
        barrelBase.transform.rotation = rot;
    }
}
