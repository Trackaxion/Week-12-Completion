using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject cloud;
    //Coin by Donovan Peckham
    public GameObject coin;
    private int score;

    // Added by Isaiah Lopez
    private int lives;
    public TextMeshProUGUI livesText;

    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f);
        //creatcoin by Donovan Peckham
        InvokeRepeating("CreateCoin", 1f, 3f);
        CreateSky();
        score = 0;
        scoreText.text = "Score: " + score;

        // Added by Isaiah Lopez
        lives = 3;
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 7.5f, 0), Quaternion.identity);
    }

    void CreateSky()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(cloud, transform.position, Quaternion.identity);
        }
    }

    public void EarnScore(int howMuch)
    {
        score = score + howMuch;
        scoreText.text = "Score: " + score;
    }

    //by Donovan Peckham
    void CreateCoin()
    {
        
        Instantiate(coin, new Vector3(Random.Range(-9f, 9f), 7.5f, 0), Quaternion.identity);
    }

    // Added by Isaiah Lopez
    public void LoseLife(int howMuch)
    {
        lives = lives - howMuch;
        livesText.text = "Lives: " + lives;
    }
}
