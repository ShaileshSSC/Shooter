using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private SystemManager sysRef;
    // Start is called before the first frame update
    void Start()
    {
        sysRef = GetComponent<SystemManager>();
        scoreText.text = "Kills: " + sysRef.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        scoreText.text = "Kills: " + sysRef.score;
    }
}
