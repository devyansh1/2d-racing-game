using UnityEngine;
using System.Collections;

public class StraightMidMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
        GameManager.Instance.onGameOver.AddListener(OnGameOver);
    }

    void OnEnable()
    {
        //GameManager.Instance.onGameOver.AddListener(OnGameOver);
    }

    public void OnGameOver()
    {
        rb.velocity = Vector2.zero;
    }

    //Update is called once per frame
    //void Update()
    //{
    //    if (GameManager.Instance.gameOver)
    //        rb.velocity = Vector2.zero;
    //}
}
