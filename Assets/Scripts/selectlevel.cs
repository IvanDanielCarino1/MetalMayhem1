using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pvp : MonoBehaviour
{
    public GameObject Canvas;
    public void Play()
    {
        Canvas.SetActive(true);
    }
    public void Pause()
    {
        Canvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        Canvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        SceneManager.LoadScene(1);
    }
}
