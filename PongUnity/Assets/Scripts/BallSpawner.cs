using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject ballPrefab;

    GameObject currentBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }
    }

    public void SpawnBall()
    {
        //Spawns the ball based on ball prefab
        currentBall = Instantiate(ballPrefab, spawnPosition.position, transform.rotation, null);

        //Creates new vector direction that will be assigned to the ball
        float randX = Random.Range(-1.5f, 1.5f);
        float randY = Random.Range(-1.5f, 1.5f);
        Vector3 newDirection = new Vector3(randX, randY, 0);
        
        //Apply the new direction to the ball
        currentBall.GetComponent<Ball>().direction = newDirection;

    }

    public void CheckBoundries()
    {

    }
}
