using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class ScoreBoard : MonoBehaviour
{
    public static ScoreBoard Instance;

    private int p1Score;
    private int p2Score;
    public int winScore;
    public string winMessage;
    
    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public TextMeshProUGUI winMessageText;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CheckWin()
    {
        if (p1Score >= winScore)
        {
            winMessageText.text = "PLAYER 1 ACHIEVES " + winMessage;
        }
        else if (p2Score >= winScore)
        {
            winMessageText.text = "PLAYER 2 ACHIEVES " + winMessage;
        }
        else
        {
            BallSpawner.Instance.SpawnBall();
        }
    }

    public void GivePointToP1()
    {
        p1Score++; //++ means add 1
        p1ScoreText.SetText(p1Score.ToString());
        CheckWin();
    }

    public void GivePointToP2()
    {
        p2Score++;
        p2ScoreText.SetText(p2Score.ToString());
        CheckWin() ;
    }
}
