using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameControl : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI smallEnemyText;
    [SerializeField] TextMeshProUGUI bigEnemyText;
    int smallEnemyCount, bigEnemyCount,characterCount;
    public GameObject WinScreen;
    public GameObject Losescreen;
    public GameObject Restartscreen;
    [SerializeField] TextMeshProUGUI characterText;

    void Start()
    {
        smallEnemyCount = GameObject.FindGameObjectsWithTag("smallEnemy").Length;
        bigEnemyCount = GameObject.FindGameObjectsWithTag("bigEnemy").Length;
        characterCount = GameObject.FindGameObjectsWithTag("Player").Length;

        smallEnemyText.text = "SMALL ENEMY : " + smallEnemyCount.ToString();
        bigEnemyText.text = "BIG ENEMY : " + bigEnemyCount.ToString();
    }


    void Update()
    {
        if (smallEnemyCount == 0 && bigEnemyCount == 0)
        {
            WinScreen.SetActive(true);
            Restartscreen.SetActive(true);
        }
        else if (characterCount==0)
        {
            Losescreen.SetActive(true);
            Restartscreen.SetActive(true);
        }
        

        
    }

  
    public void ResetGAME()
    {
        SceneManager.LoadScene("Game");

    }
}
