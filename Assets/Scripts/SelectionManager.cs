using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionManager : MonoBehaviour
{
    public GameObject[] cars;
    public int currentCar;
    public bool inGamePlayScene = false;
    void Start()
    {
        int selectedCar = PlayerPrefs.GetInt("SelectedCarID");
        if (inGamePlayScene == true)
        {
            cars[selectedCar].SetActive(true);
            currentCar = selectedCar;
        }

    }

    void Update()
    {
        
    }
    public void Right()
    {
        if (currentCar < cars.Length - 1)
        {
            currentCar += 1;
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].SetActive(false);
                cars[currentCar].SetActive(true);
            }
        }
    }
    public void Left()
    {
        if (currentCar > 0)
        {
            currentCar -= 1;
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].SetActive(false);
                cars[currentCar].SetActive(true);
            }
        }
    }
    public void Select()
    {
        PlayerPrefs.SetInt("SelectedCarID", currentCar);
        SceneManager.LoadScene(4);
    }
}
