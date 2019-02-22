using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{

    [Tooltip("Explosion prefab")]
    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject newExplosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        newExplosion.transform.localScale = new Vector3(2f, 2f, 2f);
        Destroy(gameObject);
    }
}
