using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement : MonoBehaviour
{
    public float speed = 30;
    public string axis;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw(axis);
        if(axis == "Vertical" || axis == "Vertical2")
        {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,v) * speed;
        }
        
        else if(axis == "Horizontal" || axis == "Horizontal2")
        {
        GetComponent<Rigidbody2D>().velocity = new Vector2(v,0) * speed;
        }
    }
}
