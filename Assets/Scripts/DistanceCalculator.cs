using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceCalculator : MonoBehaviour
{
    private Rigidbody2D rb;
    public StraightMidMove straightMidMove;
    public Text distanceText;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * straightMidMove.speed;
    }

    private void Update()
    {
        if (GameManager.Instance.gameOver == false)
        {
            distanceText.text = "Distance: " + (gameObject.transform.position.y).ToString("F0");
        }      
    }
}
