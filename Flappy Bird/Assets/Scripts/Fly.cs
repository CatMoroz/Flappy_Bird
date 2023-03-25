using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fly : MonoBehaviour
{
    public Game_Manager gameManager;
    public float velocity = 1;
    private float rotationZ = 0; 
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (gameManager.gameOverCanvas.activeInHierarchy == true)
        {
            rotationZ += 0.5f;
        }
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotationZ));
        rotationZ -= 0.5f;
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
            rotationZ = 80;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
