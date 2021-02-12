using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 45;
    public bool startAgain = true;
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    public void Update()
    {
        if(startAgain){
            moveBall();
            startAgain =false;
        }
    }
    public void moveBall() {
        int randoz = Random.Range(0,2);

        if(randoz == 1)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        else if(randoz == 0)
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;

    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        if(col.gameObject.tag == "LeftWall" || col.gameObject.tag == "RightWall")
        {
            startAgain = true;
        }
    }
}
