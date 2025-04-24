using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public int ballCount = 8;
    public float ballSpeed = 5f;
    public Vector3 areaSize = new Vector3(20, 0, 20);

    public List<GameObject> ballsList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        CreateBall();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateBall()
    {
        for (int i = 0; i < ballCount; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-areaSize.x / 2+1, areaSize.x / 2-1), 0.5f, Random.Range(-areaSize.z / 2+1, areaSize.z / 2-1));
            GameObject ball = Instantiate(ballPrefab, randomPos, Quaternion.identity);
            Rigidbody rb = ball.AddComponent<Rigidbody>();
            rb.useGravity = false;
            rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;

            Ball ballMove = ball.AddComponent<Ball>();
            ballMove.speed = ballSpeed;
        }
    }
}
