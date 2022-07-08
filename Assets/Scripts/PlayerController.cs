using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10.0f;
    float translation;

    // Start is called before the first frame update
    void Start()
    { 
        float translation = Input.GetAxis("Horizontal") * Speed;
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(0, 0, translation);
    }
}
//