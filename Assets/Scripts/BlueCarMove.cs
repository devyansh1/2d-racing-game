using UnityEngine;
using System.Collections;

public class BlueCarMove : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 1.8f;
    public float moveSpeed = 1.8f;
    public float upSpeed = 2.5f;
    float leftBoundary;
    float rightBoundary;
    private int currentDirection = 1;

    public SpawnerRoad spawnerRoad;

    // Use this for initialization
    void Start()
    {
        spawnerRoad = FindObjectOfType<SpawnerRoad>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;

        StartCoroutine(SideMovement());
    }

    IEnumerator SideMovement()
    {
        while (true)
        {
            if ((int)spawnerRoad.currentState == 0)
            {
                rb.transform.Translate(Vector2.right * moveSpeed * currentDirection * Time.deltaTime);
                leftBoundary = -1.42f;
                rightBoundary = 1.42f;
                if (rb.transform.position.x <= leftBoundary)
                {
                    yield return new WaitForSeconds(0.8f);
                    currentDirection = 1;
                }
                else if (rb.transform.position.x >= rightBoundary)
                {
                    yield return new WaitForSeconds(0.8f);
                    currentDirection = -1;
                }
            }
            else if ((int)spawnerRoad.currentState == 2)
            {
                rb.transform.Translate(Vector2.right * moveSpeed * currentDirection * Time.deltaTime);
                leftBoundary = -0.42f;
                rightBoundary = 2.42f;
                if (rb.transform.position.x <= leftBoundary)
                {
                    yield return new WaitForSeconds(0.8f);
                    currentDirection = 1;
                }
                else if (rb.transform.position.x >= rightBoundary)
                {
                    yield return new WaitForSeconds(0.8f);
                    currentDirection = -1;
                }
            }
            else if ((int)spawnerRoad.currentState == 6)
            {
                rb.transform.Translate(Vector2.right * moveSpeed * currentDirection * Time.deltaTime);
                leftBoundary = -2.47f;
                rightBoundary = 0.52f;
                if (rb.transform.position.x <= leftBoundary)
                {
                    yield return new WaitForSeconds(0.8f);
                    currentDirection = 1;
                }
                else if (rb.transform.position.x >= rightBoundary)
                {
                    yield return new WaitForSeconds(0.8f);
                    currentDirection = -1;
                }
            }
            yield return null;
        }
    }

    void OnEnable()
    {
        GameManager.Instance.onGameOver.AddListener(OnGameOver);
    }

    public void OnGameOver()
    {
        rb.velocity = Vector2.up * upSpeed;
    }

    //void Update()
    //{
        
    //    if (GameManager.Instance.gameOver)
    //         rb.velocity = Vector2.up * upSpeed;
    //}

}
