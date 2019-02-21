using UnityEngine;

public class Explosion : MonoBehaviour
{
    private void Start()
    {
        // We destroy the object at the end of the animation
        Destroy(gameObject, 0.417f);
    }
}
