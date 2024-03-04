using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreDisplay;
    [SerializeField] private TextMeshProUGUI bugDisplay;
    public GameObject buttonPlay;
    public GameObject buttonLoseText;

    GameManager gameManager;

    // Start is called before the first frame update
    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    private void OnGUI()
    {
        scoreDisplay.text = ("Score") + gameManager.ScoreDisplay();
        bugDisplay.text = gameManager.currentBug.ToString();
    }
    
    public void StartGame()
    {
        buttonLoseText.gameObject.SetActive(false);
        buttonPlay.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        buttonLoseText.gameObject.SetActive(true);
        buttonPlay.gameObject.SetActive(true);
    }
}
