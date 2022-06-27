using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyGenerator : MonoBehaviour
{
    //public static EnemyGenerator Instance;
    public GameObject theEnemy;
    public Text WaveAlert;
    
    public int xPos,xPos2;
    public int zPos, zPos2;
    
    public float spawnCoolDown;
    public float waveCoolDown;
    
    public int enemyCounter;
    public int enemyLimit;
    public int enemyWave;

    /*private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(gameObject);
    }*/

    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        for(enemyWave = 1; enemyWave < 5; enemyWave++)
        {
            WaveAlert.GetComponent<Text>().text = "DAY " + enemyWave.ToString();
            yield return new WaitForSeconds(2f);
            WaveAlert.GetComponent<Text>().text = "";
            
            yield return new WaitForSeconds(waveCoolDown);
            enemyCounter = 0;           
            
            while (enemyCounter < enemyLimit)
            {
                enemyCounter += 2;
                xPos = Random.Range(20, 25);
                zPos = Random.Range(-25, 25);

                xPos2 = Random.Range(-20, -25);
                zPos2 = Random.Range(-25, 25);

                Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
                Instantiate(theEnemy, new Vector3(xPos2, 1, zPos2), Quaternion.identity);
                yield return new WaitForSeconds(spawnCoolDown);
            }
            enemyLimit += 2;
        }
            
        
    }
}
