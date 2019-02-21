using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Tooltip("Base of the barrel of the tank")]
    public Transform barrelBase;

    [Tooltip("Output of the barrel")]
    public Transform barrelOutput;

    [Tooltip("Prefab of the bullet shoot by the player")]
    public GameObject bulletPrefab;

    private Rigidbody2D rb; // Component that control the physics of the object

    private const float speed = 200f;
    private const float rotateSpeed = 3500f;
    private const float bulletSpeed = 10f;

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
        rb.velocity = -transform.up * forward * Time.deltaTime * speed;
        rb.angularVelocity = -horizontal * Time.deltaTime * rotateSpeed;

        // Set barrel rotation to look at mouse
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Quaternion rot = barrelBase.transform.rotation;
        rot.SetFromToRotation(-Vector3.up, (mousePos - barrelBase.transform.position));
        barrelBase.transform.rotation = rot;

        // Fire bullet when player press button associated to "Fire1"
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject go = Instantiate(bulletPrefab, barrelOutput.position, rot * Quaternion.Euler(180f, 0f, 0f));
            go.GetComponent<Rigidbody2D>().AddForce(go.transform.up * bulletSpeed, ForceMode2D.Impulse);
        }
    }
}
