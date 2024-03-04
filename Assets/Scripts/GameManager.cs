using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton

    public static GameManager Instance;

    [SerializeField] private UI_Manager uiManager;

    public int maxBug = 15;
    public int currentBug = 4;


    //Awake happens before Start. Set GameManager to whatever this sceipt is attached to.
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }



    #endregion

    public float currentScore = 0f;

    public bool isPlaying = false;

    public string ScoreDisplay()
    {
        return Mathf.RoundToInt(currentScore).ToString();
    }

    public void GameOver()
    {
        uiManager.GameOver();
        isPlaying = false;
    }

    private void Update()
    {
        if (isPlaying == true)
        {
            currentScore += Time.deltaTime;
        }

        if(Input.GetKeyDown("p"))
        {
            isPlaying = true;
        }
    }

    public void BugCollect()
    {

    }
  
}
