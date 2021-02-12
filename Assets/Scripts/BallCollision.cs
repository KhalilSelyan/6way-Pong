using UnityEngine;
public class BallCollision : MonoBehaviour
{
    public AudioSource hit;
    public GameObject spawnedBall;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        hit = GetComponent<AudioSource>();
        // Hit the LeftRacket or RightRacket by checking from the tag of that gameobject
        //Adjust the ball collision angle
        if (col.gameObject.tag == "LeftRacket" || col.gameObject.tag == "RightRacket")
        {
            hit.Play();
            Vector2 vel;
            vel.x = GetComponent<Rigidbody2D>().velocity.x;
            vel.y = (GetComponent<Rigidbody2D>().velocity.y / 2.0f) + (col.collider.attachedRigidbody.velocity.y / 3.0f);
            GetComponent<Rigidbody2D>().velocity = vel;
        }

        if (col.gameObject.tag == "LeftWall" || col.gameObject.tag == "RightWall")
        {
            // SpawnBall();    
            // StartCoroutine(GameObject.FindWithTag("MainCamera").GetComponent<BallSpawner>().Spawner());

            // GameObject.FindWithTag("MainCamera").GetComponent<BallSpawner>().StartCoroutine(Spawner());
            GameObject.FindWithTag("MainCamera").GetComponent<BallSpawner>().SpawnBallWithEfeHoca();
            Destroy(this.gameObject);




        }
    }

}
