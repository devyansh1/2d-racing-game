using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    public float moveSpeed = 4f;
    private Rigidbody2D rb;
    private Animator _anim;
    private BoxCollider2D _coll;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            _anim = GetComponent<Animator>();
            _coll = GetComponent<BoxCollider2D>();
        }

        void FixedUpdate()
        {
            if (GameManager.Instance.gameOver == false)
            {
                float moveHorizontal = Input.GetAxis("Horizontal");
                Vector2 movement = new Vector2(moveHorizontal * moveSpeed, rb.velocity.y);
                rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
            }
        }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyCar"))
        {
            _anim.SetTrigger("OnPlayerCrash");
            //_anim.Play();
            _coll.enabled = false;
            Destroy(gameObject, 1.3f);
            GameManager.Instance.GameOver();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BoundaryWall"))
        {
            //_anim.Play("Explosion", PlayMode.StopAll);
            _anim.SetTrigger("OnPlayerCrash");
            _coll.enabled = false;
            Destroy(gameObject, 1.3f);
            GameManager.Instance.GameOver();
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
