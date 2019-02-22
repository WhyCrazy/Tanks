using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Tooltip("Explosion prefab")]
    public GameObject explosionPrefab;

    private void Start()
    {
        // We destroy the object after 10 seconds
        Destroy(gameObject, 10f);
    }

    // On collision we destroy the bullet and spawn an explosion
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject newExplosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        newExplosion.transform.localScale = new Vector3(1f, 1f, 1f);
        Destroy(gameObject);
    }
}
