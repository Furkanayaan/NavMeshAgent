using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{

    public GameObject ForestCoinPrefab;
    private float xPos;
    private float zPos;
    public float respawnTime = 2f;
    

    void Start()
    {
        StartCoroutine(coinWave());
    }


    private void spawnCoin()
    {
        xPos = Random.Range(-12.6f, 12.5f);
        zPos = Random.Range(-10.76f, 11.3f);
        RaycastHit hit;
        if (Physics.Raycast(new Vector3(xPos, 15, zPos), Vector3.down,out hit, Mathf.Infinity))
        {
            if (!hit.collider.CompareTag("Wall")) 
                Instantiate(ForestCoinPrefab, new Vector3(xPos, 1.32f, zPos), Quaternion.identity);

            
                
        }
            
                
        
    }
    IEnumerator coinWave()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(respawnTime);
            spawnCoin();
            

        }


    }

}
