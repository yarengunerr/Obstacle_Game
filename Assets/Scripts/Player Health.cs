using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class PlayerHealth : MonoBehaviour
{
    public Image[] hearts; 
    public Sprite HeartImage; 
    [SerializeField] private int health=3;
   
   [SerializeField] GameOver gameOver;

    void Start()
    {
        health = hearts.Length; // Başlangıçta tüm kalpler dolu
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
            health--; 
            hearts[health].gameObject.SetActive(false);
            Debug.Log("damage yedi");

            
        }



        if (health == 0)
            {
                GameOver(); 
            }
    }

    private void GameOver()
    {
        
        Debug.Log("Game Over!");
        Time.timeScale = 0; 
        gameOver.OpenGameOverPanel();
    }
}

