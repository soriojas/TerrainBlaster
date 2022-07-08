using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    { 
        float translation = Input.GetAxis("Vertical") * speed;
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(0, 0, translation);
    }
}
//