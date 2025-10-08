using UnityEngine;
using System.Collections;
using System.Timers;
public class SpawnerRoad : MonoBehaviour
{
    public GameObject prefabToSpawnMiddle;
    public GameObject prefabToSpawnMiddleToRight;
    public GameObject prefabToSpawnRightStraight;
    public GameObject prefabToSpawnRightToMiddle;
    public GameObject prefabToSpawnMiddleToLeft;
    public GameObject prefabToSpawnLeftStraight;
    public GameObject prefabToSpawnLeftToMiddle;
    public int carSpawnAt = 4;
    private int spawnCount = 0;

    public SpawnerCar spawnerCar;

    public Vector3 spawnPosition;
    public enum SpawnState { SpawningMid, SpawningMiddleToRight, SpawningRight, SpawningRightToMiddle, SpawningMiddleToLeft, SpawningLeft, SpawningLeftToMiddle }
    public SpawnState currentState = SpawnState.SpawningMid;
    //private static System.Timers.Timer aTimer;
    public float totalTime = 5;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (GameManager.Instance.gameOver == false)
        {
            if (other.CompareTag("StraightMid") || other.CompareTag("StraightToRight") || other.CompareTag("StraightRight") || other.CompareTag("RightToMiddle") || other.CompareTag("LeftToMiddle") || other.CompareTag("MiddleToLeft") || other.CompareTag("StraightLeft"))
            {
                spawnCount++;
                SpawnNextRoadPiece();
                Destroy(other.gameObject);
                if (spawnCount >= carSpawnAt)
                {
                    spawnerCar.SpawnCar();
                    spawnCount = 0;
                }
            }
            else if (other.CompareTag("EnemyCar"))
            {
                Destroy(other.gameObject);
            }
        }      
    }

    //void Start()
    //{
    //    SetTimer();
    //}

    void Update()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
        }
        if(totalTime < 4 && spawnerCar.spawnOrNot == true)
        {
            Debug.Log("Time added");
            totalTime += 4;
        }
        if(totalTime <= 0)
        {
            ChangeState();
            totalTime = 5;
        }
    }

    //private void SetTimer()
    //{
    //        aTimer = new System.Timers.Timer(5000);

    //        aTimer.Elapsed += ChangeState;
    //        aTimer.AutoReset = true;
    //        aTimer.Enabled = true;
    //}

    void ChangeState()
    {
        switch (currentState)
        {
            case SpawnState.SpawningMid:
                if (Random.Range(1, 3) == 1)
                {
                    currentState = SpawnState.SpawningMiddleToRight;
                }
                else
                {
                    currentState = SpawnState.SpawningMiddleToLeft;
                }
                break;

            case SpawnState.SpawningRight:
                currentState = SpawnState.SpawningRightToMiddle;
                break;

            case SpawnState.SpawningLeft:
                currentState = SpawnState.SpawningLeftToMiddle;
                break;
        }
    }

    void SpawnNextRoadPiece()
    {
        switch (currentState)
        {
            case SpawnState.SpawningMid:
                Instantiate(prefabToSpawnMiddle, spawnPosition, Quaternion.identity);
                break;

            case SpawnState.SpawningMiddleToRight:
                Instantiate(prefabToSpawnMiddleToRight, spawnPosition, Quaternion.identity);
                currentState = SpawnState.SpawningRight;
                break;

            case SpawnState.SpawningRight:
                Instantiate(prefabToSpawnRightStraight, spawnPosition, Quaternion.identity);
                break;

            case SpawnState.SpawningRightToMiddle:
                Instantiate(prefabToSpawnRightToMiddle, spawnPosition, Quaternion.identity);
                currentState = SpawnState.SpawningMid;
                break;

            case SpawnState.SpawningMiddleToLeft:
                Instantiate(prefabToSpawnMiddleToLeft, spawnPosition, Quaternion.identity);
                currentState = SpawnState.SpawningLeft;
                break;

            case SpawnState.SpawningLeft:
                Instantiate(prefabToSpawnLeftStraight, spawnPosition, Quaternion.identity);
                break;

            case SpawnState.SpawningLeftToMiddle:
                Instantiate(prefabToSpawnLeftToMiddle, spawnPosition, Quaternion.identity);
                currentState = SpawnState.SpawningMid;
                break;
        }
    }
}

//using UnityEngine;
//using System.Collections;
//using System.Timers;
//public class SpawnerRoad : MonoBehaviour
//{
//    public GameObject prefabToSpawnMiddle;
//    public GameObject prefabToSpawnMiddleToRight;
//    public GameObject prefabToSpawnRightStraight;
//    public GameObject prefabToSpawnRightToMiddle;
//    public GameObject prefabToSpawnMiddleToLeft;
//    public GameObject prefabToSpawnLeftStraight;
//    public GameObject prefabToSpawnLeftToMiddle;

//    public Vector3 spawnPosition;
//    public int straightMidCount = 15;
//    public int middleToRightCount = 1;
//    public int straightRightCount = 10;
//    public int rightToMiddleCount = 1;
//    public int middleToLeftCount = 1;
//    public int straightLeftCount = 10;
//    public int leftToMiddleCount = 1;
//    public enum SpawnState { SpawningMid, SpawningMiddleToRight, SpawningRight, SpawningRightToMiddle, SpawningMiddleToLeft, SpawningLeft, SpawningLeftToMiddle }
//    public SpawnState currentState = SpawnState.SpawningMid;

//    void OnTriggerEnter2D(Collider2D other)
//    {
//        if (other.CompareTag("StraightMid") || other.CompareTag("StraightToRight") || other.CompareTag("StraightRight") || other.CompareTag("RightToMiddle") || other.CompareTag("LeftToMiddle") || other.CompareTag("MiddleToLeft") || other.CompareTag("StraightLeft"))
//        {
//            SpawnNextRoadPiece();
//            Destroy(other.gameObject);
//        }
//        else if (other.CompareTag("EnemyCar"))
//        {
//            Destroy(other.gameObject);
//        }
//    }

//    void Start()
//    {
//        StartCoroutine(WaitFiveSeconds());
//    }
//    IEnumerator WaitFiveSeconds()
//    {
//        while (true)
//        {
//            yield return new WaitForSeconds(5);
//            ChangeState();
//        }
//    }

//    void ChangeState()
//    {
//        switch (currentState)
//        {
//            case SpawnState.SpawningMid:
//                if (Random.Range(1,3) == 1)
//                {
//                    currentState = SpawnState.SpawningMiddleToRight;
//                }
//                else
//                {
//                    currentState = SpawnState.SpawningMiddleToLeft;
//                }
//                break;

//            case SpawnState.SpawningRight:
//                currentState = SpawnState.SpawningRightToMiddle;
//                break;

//            case SpawnState.SpawningLeft:
//                currentState = SpawnState.SpawningLeftToMiddle;
//                break;
//        }
//    }

//    void SpawnNextRoadPiece()
//    {
//        switch (currentState)
//        {
//            case SpawnState.SpawningMid:
//                Instantiate(prefabToSpawnMiddle, spawnPosition, Quaternion.identity);
//                break;

//            case SpawnState.SpawningMiddleToRight:
//                Instantiate(prefabToSpawnMiddleToRight, spawnPosition, Quaternion.identity);
//                currentState = SpawnState.SpawningRight;
//                break;

//            case SpawnState.SpawningRight:
//                Instantiate(prefabToSpawnRightStraight, spawnPosition, Quaternion.identity);
//                break;

//            case SpawnState.SpawningRightToMiddle:
//                Instantiate(prefabToSpawnRightToMiddle, spawnPosition, Quaternion.identity);
//                currentState = SpawnState.SpawningMid;
//                break;

//            case SpawnState.SpawningMiddleToLeft:
//                Instantiate(prefabToSpawnMiddleToLeft, spawnPosition, Quaternion.identity);
//                currentState = SpawnState.SpawningLeft;
//                break;

//            case SpawnState.SpawningLeft:
//                Instantiate(prefabToSpawnLeftStraight, spawnPosition, Quaternion.identity);
//                break;

//            case SpawnState.SpawningLeftToMiddle:
//                Instantiate(prefabToSpawnLeftToMiddle, spawnPosition, Quaternion.identity);
//                currentState = SpawnState.SpawningMid;
//                break;
//        }
//    }
//}





