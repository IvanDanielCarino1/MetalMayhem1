using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public float health;
    public Slider HealthBar;
    public GameObject gameOverScreen;
    public AudioSource sound;
    public AudioSource bg;

    private void Start()
    {
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer.Equals(6) || other.gameObject.layer.Equals(8))
        {
            HealthBar.value = health;
            health -= 1;
        }
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.layer.Equals(6) || other.gameObject.layer.Equals(8))
        {
            HealthBar.value = health;
            health -= 1;

            if (health <= 0)
            {
                GameOver();
                sound.Play();
                bg.Stop();
            }

        }
    }
}
