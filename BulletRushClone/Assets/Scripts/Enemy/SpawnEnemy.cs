using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnEnemy : MonoBehaviour
{
    private float FirstSpawnPosX = 0.91f;
    private float FirstSpawnPosY = 2.46f;
    private float FirstSpawnPosZ = -129.4f;

    [SerializeField] public int smallEnemyCount;
    [SerializeField] public int bigEnemyCount;

    [SerializeField] private GameObject smallEnemy;
    [SerializeField] private GameObject bigEnemy;
    Vector3 scaleChange;


    void Awake()
    {
        EnemySpawn();
        smallEnemy.transform.localScale = new Vector3(1f, 1f, 1f);
        bigEnemy.transform.localScale = new Vector3(1f, 1f, 1f);
    }


    public void EnemySpawn()
    {

        scaleChange = new Vector3(1f, 1f, 1f);

        for (int i = 0; i < smallEnemyCount; i++)
        {
            smallEnemy.transform.localScale += scaleChange;
            Instantiate(smallEnemy, new Vector3(FirstSpawnPosX, FirstSpawnPosY, FirstSpawnPosZ - 6.7f), Quaternion.identity);
            smallEnemy.transform.localScale -= scaleChange;
            FirstSpawnPosX += 3;
        }

        scaleChange = new Vector3(1.5f, 1.5f, 1.5f);
        FirstSpawnPosX = 2.91f;

        for (int i = 0; i < bigEnemyCount; i++)
        {
            bigEnemy.transform.localScale += scaleChange;
            Instantiate(bigEnemy, new Vector3(FirstSpawnPosX, FirstSpawnPosY, FirstSpawnPosZ), Quaternion.identity);
            bigEnemy.transform.localScale -= scaleChange;
            FirstSpawnPosX += 4;
        }




    }



}
