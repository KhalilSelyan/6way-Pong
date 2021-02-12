using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject spawnedBall;

    void Start()
    {
        //StartCoroutine(Spawner());
    }


    // Start is called before the first frame update
    private void SpawnBall() 
    {
        Instantiate(spawnedBall, new Vector2(-4.3f, 10), Quaternion.identity);
        // Instantiate(spawnedBall, new Vector2(-4.3f, 10), Quaternion.identity);
    }

    
    public IEnumerator Spawner()
    {
            Debug.Log("Coroutine entered");
            yield return new WaitForSeconds(2f);
            SpawnBall();
            Debug.Log("Coroutine Left");
        
    }

    public void SpawnBallWithEfeHoca()
    {
        // Invoke("SpawnBall", 2);
        StartCoroutine(Spawner());
    }
}
