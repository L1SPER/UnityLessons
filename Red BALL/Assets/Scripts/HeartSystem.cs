using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    [SerializeField] GameObject[] hearts;
    public GameObject redBall;
    public GameObject block;
    public Vector3 ballPos;
    public Vector3 blockPos;

    public int health;
    private bool dead;
    private bool wounded;

    public void playAgain()
    {
        LoadHealth();
        FindObjectOfType<RestartMenu>().setCanvasNotActive();
        FindObjectOfType<Utilies>().Respawn();
        Instantiate(block, blockPos, Quaternion.identity);
        Time.timeScale = 1;
    }
    public void SaveHealth()
    {
        SaveSystem.SaveHealth(this);
    }
    public void LoadHealth()
    {
        PlayerData data = SaveSystem.LoadHealth();
        health = data.health;   
    }
    public void TakeDamage(int damage)
    {
        if (health >=1)
        {
            health -= damage;
            hearts[health].gameObject.SetActive(false);
            Die();
        }
    }
    public void Die()
    {
        SaveHealth();
        if (health < 1)
        {
            dead = true;
        }
        else
        {
            wounded = true;
            Time.timeScale = 0;
        }
        
    }
}
