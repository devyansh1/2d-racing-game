using System.Collections;
using UnityEngine;

public class SpawnerCar : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject carPrefabBlue;
    public SpawnerRoad spawnerRoad;
    public EnemyCarMove enemyCarMove;
    //public float prevXMiddle = -1.4f;
    //public float prevXRight = -0.4f;
    //public float prevXLeft = -2.45f;
    public bool spawnOrNot = false;

    public void SpawnCar()
    {
        if (Random.Range(0, 100) < 45)
        {
            //if (spawnerRoad.currentState.SpawnState == spawnerRoad.SpawnState.SpawningMid)
            if ((int)spawnerRoad.currentState == 0)
            {
                Vector2 randomPosition = GetRandomPositionMiddle();
                if (Random.Range(0,100) < 33)
                {
                    GameObject newCar = Instantiate(carPrefabBlue, randomPosition, Quaternion.identity) as GameObject;
                    newCar.transform.parent = transform;
                }
                else
                {
                    GameObject newCar = Instantiate(carPrefab, randomPosition, Quaternion.identity) as GameObject;
                    newCar.transform.parent = transform;
                }
                spawnOrNot = true;
            }
            else if ((int)spawnerRoad.currentState == 2)
            {
                Vector2 randomPosition = GetRandomPositionRight();
                if (Random.Range(0, 100) < 33)
                {
                    GameObject newCar = Instantiate(carPrefabBlue, randomPosition, Quaternion.identity) as GameObject;
                    newCar.transform.parent = transform;
                }
                else
                {
                    GameObject newCar = Instantiate(carPrefab, randomPosition, Quaternion.identity) as GameObject;
                    newCar.transform.parent = transform;
                }
                spawnOrNot = true;
            }
            else if ((int)spawnerRoad.currentState == 6)
            {
                Vector2 randomPosition = GetRandomPositionLeft();
                if (Random.Range(0, 100) < 33)
                {
                    GameObject newCar = Instantiate(carPrefabBlue, randomPosition, Quaternion.identity) as GameObject;
                    newCar.transform.parent = transform;
                }
                else
                {
                    GameObject newCar = Instantiate(carPrefab, randomPosition, Quaternion.identity) as GameObject;
                    newCar.transform.parent = transform;
                }
                spawnOrNot = true;
            }
        }
        else
            spawnOrNot = false;
    }

    Vector2 GetRandomPositionMiddle()
    {
        float randomX = Random.Range(-1.4f, 1.4f);

        return new Vector2(randomX, 3.72f);
    }
    Vector2 GetRandomPositionRight()
    {
        float randomX = Random.Range(-0.4f, 2.4f);

        return new Vector2(randomX, 3.72f);
    }

    Vector2 GetRandomPositionLeft()
    {
        float randomX = Random.Range(-2.45f, 0.5f);

        return new Vector2(randomX, 3.72f);
    }

    //Vector2 GetRandomPositionMiddle(float prevX)
    //{
    //    float randomX = Random.Range(-1.4f, 1.4f);

    //    while(System.Math.Abs(randomX - prevX) < 1)
    //        randomX = Random.Range(-1.4f, 1.4f);

    //    return new Vector2(randomX, 3.72f);
    //}
    //Vector2 GetRandomPositionRight(float prevX)
    //{
    //    float randomX = Random.Range(-0.4f, 2.4f);

    //    while(System.Math.Abs(randomX - prevX) < 1)
    //        randomX = Random.Range(-0.4f, 2.4f);

    //    return new Vector2(randomX, 3.72f);
    //}

    //Vector2 GetRandomPositionLeft(float prevX)
    //{
    //    float randomX = Random.Range(-2.45f, 0.5f);

    //    while (System.Math.Abs(randomX - prevX) < 1)
    //        randomX = Random.Range(-2.45f, 0.5f);

    //    return new Vector2(randomX, 3.72f);
    //}
}

