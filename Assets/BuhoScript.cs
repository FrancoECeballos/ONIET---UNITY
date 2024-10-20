using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuhoScript : MonoBehaviour
{
    public GameObject buho;
    public Rigidbody2D buhoRb;
    public float speed;
    private Camera mainCamera;
    private Animator animator;
    private bool gameOver = false;

    public GameLogicScript gameLogic;

    void Start()
    {
        mainCamera = Camera.main;
        buhoRb.constraints = RigidbodyConstraints2D.FreezeRotation;
        animator = buho.GetComponent<Animator>();
    }

    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKey(KeyCode.Space) && gameLogic != null)
            {
                gameLogic.restartGame();
            }
            return;
        }

        Vector2 newVelocity = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            newVelocity += Vector2.up * speed;
        }   
        if (Input.GetKey(KeyCode.A))
        {
            newVelocity += Vector2.left * speed;
        }   
        if (Input.GetKey(KeyCode.S))
        {
            newVelocity += Vector2.down * speed;
        }   
        if (Input.GetKey(KeyCode.D))
        {
            newVelocity += Vector2.right * speed;
        }

        buhoRb.velocity = Vector2.Lerp(buhoRb.velocity, newVelocity, 0.5f);

        Vector3 clampedPosition = mainCamera.WorldToViewportPoint(buho.transform.position);
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, 0.05f, 0.95f);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, 0.05f, 0.95f);
        buho.transform.position = mainCamera.ViewportToWorldPoint(clampedPosition);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Worm"))
        {
            collision.gameObject.SetActive(false);
            if (gameLogic != null)
            {
                gameLogic.gameScore += 500;
            }
        }
        else if (!collision.gameObject.CompareTag("Floor"))
        {
            gameOver = true;
            buhoRb.velocity = Vector2.zero;
            buhoRb.gravityScale = 1;
            buhoRb.mass = 0.1f;
            animator.enabled = false;

            if (gameLogic != null)
            {
                gameLogic.gameOver();
            }
        }
        else if (collision.gameObject.CompareTag("Floor"))
        {
            animator.SetBool("OnFloor", true);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            animator.SetBool("OnFloor", false);
        }
    }
}