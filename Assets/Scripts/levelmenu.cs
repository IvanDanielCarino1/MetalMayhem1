using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelmenu : MonoBehaviour
{
public void OpenLevel(int levelId)
{
     string levelName = "Level" + levelId;
     SceneManager.LoadScene(levelName); 
}
}
