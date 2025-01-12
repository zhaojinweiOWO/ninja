using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameManager gameManager;
    public int life = 10;

    void Start()
    {
        if (gameManager == null)
        {
            Debug.LogError("GameManager is not assigned in Cat script.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Arrow")
        {
            Debug.Log("Arrow hit the cat!");
            gameManager.DecreaseHp();
            life -= 1;
            Destroy(collision.gameObject);

            if (life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }


    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}
