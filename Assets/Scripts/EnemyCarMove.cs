using UnityEngine;
using System.Collections;

public class EnemyCarMove : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 1.8f;
    public float upSpeed = 2.5f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }

    void OnEnable()
    {
        GameManager.Instance.onGameOver.AddListener(OnGameOver);
    }

    public void OnGameOver()
    {
        rb.velocity = Vector2.up * upSpeed;
    }
}
//void Update()
//{
//    if (GameManager.Instance.gameOver)
//        rb.velocity = Vector2.up * upSpeed;
//}
//}
