using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerHealth = 1;

    void GameOver()
    {
        Debug.Log("Game Over1");
        FindObjectOfType<TouchToRotate>().DeathParticle();
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
