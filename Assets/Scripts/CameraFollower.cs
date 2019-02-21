using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [Tooltip("Object to follow")]
    public Transform toFollow;

    private void Update()
    {
        transform.position = new Vector3(toFollow.position.x, toFollow.position.y, transform.position.z);
    }
}
