using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    public float score;
    private Interface interfaceRef;
    // Start is called before the first frame update
    void Start()
    {
        interfaceRef = GetComponent<Interface>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, new Vector3(Random.Range(-3,3), Random.Range(-3, 3), Random.Range(-3, 3)), Quaternion.identity);
    }
    public void AddScore()
    {
        score += 1;
        interfaceRef.UpdateScore();
    }
}
