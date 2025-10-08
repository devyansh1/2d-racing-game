//using System.Collections;
//using UnityEngine;

//public class CarSpawner : MonoBehaviour
//{
//    public GameObject carPrefab;
//    public float minSpawnDelay = 1f;
//    public float maxSpawnDelay = 3f;
//    private BoxCollider2D spawnArea;
//    public GameObject spawnCarRight;
//    private BoxCollider2D spawnAreaRight;

//    void Start()
//    {
//        spawnArea = GetComponent<BoxCollider2D>();
//        spawnAreaRight = spawnCarRight.GetComponent<BoxCollider2D>();
//        StartCoroutine(SpawnCarsMiddle());
//    }

//    IEnumerator SpawnCarsMiddle()
//    {
//        while (true)
//        {
//            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));

//            Vector2 randomPosition = GetRandomPositionInCollider(spawnArea);
//            GameObject newCar = Instantiate(carPrefab, randomPosition, Quaternion.identity) as GameObject;
//            newCar.transform.parent = transform; 

//        }
//    }

//    Vector2 GetRandomPositionInCollider(BoxCollider2D spawning)
//    {
//        Bounds bounds = spawning.bounds;

//        float randomX = Random.Range(bounds.min.x, bounds.max.x);
//        float randomY = Random.Range(bounds.min.y, bounds.max.y);

//        return new Vector2(randomX, randomY);
//    }
//}

