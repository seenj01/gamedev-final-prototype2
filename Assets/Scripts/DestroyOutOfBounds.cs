using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if object moves past player view then remove the object
        if (transform.position.z > 30) {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
