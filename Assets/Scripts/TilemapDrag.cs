using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapDrag : MonoBehaviour
{

    public PlayerController player;

    [Tooltip("Set Ground Speed")]
    public float ground_speed;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        player.speed = ground_speed;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        player.speed = 200f;
    }
}
