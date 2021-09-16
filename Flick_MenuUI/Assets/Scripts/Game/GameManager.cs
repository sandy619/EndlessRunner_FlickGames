using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public int score;
    public int jewel;
    public static GameManager inst;

    [SerializeField] Text scoreText;
    [SerializeField] Text jewelText;

    [SerializeField] PlayerMovement playerMovement;

    [SerializeField] GameObject GameOver;
    [SerializeField] Text FinalscoreText;
    [SerializeField] Text FinaljewelText;

    public void IncrementScore()
    {
        score++;
        PlayerPrefs.SetInt("scorePlayerPrefs", score);
        scoreText.text = "Coins: " + score;
        // Increase the player's speed
        playerMovement.forwardSpeed += playerMovement.speedIncreasePerPoint;
    }

    public void IncrementJewel()
    {
        jewel++;
        PlayerPrefs.SetInt("jewelPlayerPrefs", jewel);
        jewelText.text = "Jewel: " + jewel;
        // Increase the player's speed
        playerMovement.forwardSpeed += playerMovement.speedIncreasePerPoint;
    }

    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {
        score = 0;
        jewel = 0;
    }

    private void Update()
    {
        FinalscoreText.text = "Coins collected     :" + score;
        FinaljewelText.text = "Jewels collected   :" + jewel;
    }
}