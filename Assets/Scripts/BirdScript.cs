using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows;

public class BirdScript : MonoBehaviour
{
    public float jumpRange;
    Rigidbody2D rigidbody2d;
    public TextMeshProUGUI scoreText;
    public float score;
    public GameObject gameOverScreen;
    public bool BirdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {// Down olmasýnýn sebebi her mouse týklamasýnda bir kere çalýþmasý diðer türlü kullanýlmazsa sürekli çalýþýr
        if (UnityEngine.Input.GetMouseButtonDown(0) && BirdIsAlive == true) 
        {
            rigidbody2d.velocity = Vector2.up * jumpRange;
        }   
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Score"))
        {
            score++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Pipe"))
        {
        
            gameOver();
            BirdIsAlive = false;
        }

    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
