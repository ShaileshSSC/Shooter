using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SystemManager sysRef;
    private string sysString = "Manager";
    // Start is called before the first frame update
    void Start()
    {
        sysRef = GameObject.Find(sysString).GetComponent<SystemManager>(); 
    }

    private void OnMouseDown()
    {
        Die();
    }

    void Die()
    {
        sysRef.SpawnEnemy();
        sysRef.AddScore();
        Destroy(this.gameObject);
    }
}
