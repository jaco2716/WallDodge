using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerHealth = 1;
    public GameObject GameOverMenuUI;

    void GameOver()
    {
        Debug.Log("Game Over1");
        FindObjectOfType<TouchToRotate>().DeathParticle();

        Animator animator = GameOverMenuUI.GetComponent<Animator>();
        if (animator != null)
        {
            bool isPaused = animator.GetBool("Open");

            animator.SetBool("Open", !isPaused);
        }

    }

    public void LoseLife()
    {
        playerHealth -= 1;
        FindObjectOfType<Lives>().ChangeLifeSprite(playerHealth);
        Debug.Log("lives: " + playerHealth);
        if (playerHealth <= 0)
        {
            GameOver();
        }

    }
}
