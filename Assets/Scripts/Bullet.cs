using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Tooltip("Explosion prefab")]
    public GameObject explosionPrefab;

    // On collision we destroy the bullet and spawn an explosion
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
