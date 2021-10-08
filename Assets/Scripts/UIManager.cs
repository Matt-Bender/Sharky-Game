using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pointsText;
    [SerializeField] private TextMeshProUGUI livesText;

    private int score = 0;
    private int lives = 5;

    //Every 50 good fish eaten will spawn another group of fish
    private int scoreGoal = 50;

    SpawnFish fishSpawner;


    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highscoreText;
    [SerializeField] private GameObject scoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        scoreBoard.SetActive(false);
        fishSpawner = GameObject.Find("FishSpawner").GetComponent<SpawnFish>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score++;
        UpdateUI();
        if(score >= scoreGoal)
        {
            scoreGoal += 50;
            fishSpawner.SpawnMoreFish();
        }
    }

    public void DecreaseLives()
    {
        lives--;
        if(lives <= 0)
        {
            EnableScoreboard();
        }
        UpdateUI();
    }

    private void UpdateUI()
    {
        pointsText.text = "Points: " + score;
        livesText.text = "Lives: " + lives;
    }

    private void EnableScoreboard()
    {
        scoreBoard.SetActive(true);
        scoreText.text = "Score: " + score;
    }
}
