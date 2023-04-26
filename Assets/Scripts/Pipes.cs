using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    
    public float speed = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Move pipes left
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);


        if (transform.position.magnitude > 20f)

        {
            Destroy(gameObject);
        }
    }
}
