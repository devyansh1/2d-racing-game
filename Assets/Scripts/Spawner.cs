//using UnityEngine;
//using System.Collections;

//public class Spawner : MonoBehaviour
//{
//    public GameObject prefabToSpawn;
//    public Vector3 spawnPosition;

//    void Start()
//    {
//        InvokeRepeating("Spawn", 0, 0.2f);
//    }

//    void Spawn()
//    {
//        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}

//using UnityEngine;

//public class Spawner : MonoBehaviour
//{
//    public GameObject prefabToSpawn;

//    public float prefabHeight = 1.0f;

//    private GameObject lastSpawnedObject;

//    void Start()
//    {
//        if (prefabToSpawn == null)
//        {
//            Debug.LogError("Prefab to Spawn is not assigned!", this);
//            this.enabled = false;
//            return;
//        }
//        if (prefabToSpawn.GetComponent<Rigidbody2D>() == null)
//        {
//            Debug.LogError("The prefab is missing a Rigidbody2D component!", this);
//            this.enabled = false;
//            return;
//        }

//        Vector3 initialSpawnPos = new Vector3(
//            transform.position.x,
//            transform.position.y + (prefabHeight / 2),
//            transform.position.z
//        );
//        lastSpawnedObject = Instantiate(prefabToSpawn, initialSpawnPos, transform.rotation) as GameObject;
//    }

//    void FixedUpdate()
//    {
//        if (lastSpawnedObject == null) return;

//        float triggerY = this.transform.position.y;
//        float topEdgeOfLastObject = lastSpawnedObject.transform.position.y + (prefabHeight / 2);

//        if (topEdgeOfLastObject <= triggerY)
//        {
//            SpawnNextObject();
//        }
//    }

//    private void SpawnNextObject()
//    {
//        Vector3 nextPosition = lastSpawnedObject.transform.position + new Vector3(0, prefabHeight, 0);
//        lastSpawnedObject = Instantiate(prefabToSpawn, nextPosition, transform.rotation) as GameObject;
//    }
//}