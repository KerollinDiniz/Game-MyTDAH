//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreFinal : MonoBehaviour
{
    [SerializeField] private Text ScoreTexto;
    [SerializeField] private int Score;
    [SerializeField] private GameObject medalhaOuro;
    [SerializeField] private GameObject medalhaPrata;
    [SerializeField] private GameObject medalhaBronze;
  

    void Awake()
    {
        ScoreTexto.text = "Pontuação:";
    }

    
    void Update()
    {
        GameObject QuizManager = GameObject.Find("QuizManager");
        QuizManager playerScript = QuizManager.GetComponent<QuizManager>();
        Score = playerScript.Score;
        ScoreTexto.text = "Pontuação:" + Score;
        Debug.Log(Score);
        
        if (Score >= 200)
        {
            medalhaOuro.SetActive(true);
        }
        if (Score >= 100 && Score < 200)
        {
            medalhaPrata.SetActive(true);
        }
        if (Score <100)
        {
            medalhaBronze.SetActive(true);
        }
    }



}
