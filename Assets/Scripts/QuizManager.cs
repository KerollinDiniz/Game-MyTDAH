//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [SerializeField] private QuizUI quizUI;
    [SerializeField] private QuizDataScriptable quizData;
    [SerializeField] private int countPerguntas;
    [SerializeField] private GameObject telaResultado;
    [SerializeField] private GameObject gameMenu;
    [SerializeField] private GameObject tempo;

    public int Score;
    private List<Pergunta> perguntas;
    private Pergunta perguntaSelecionada = new Pergunta();
    public int val;

    // Start is called before the first frame update

    void Start()
    {
        perguntas = quizData.perguntas;
        SelecionarPergunta();
    }

    private void Update()
    {
        if  (countPerguntas >= 5)
        {
            telaResultado.SetActive(true);
            gameMenu.SetActive(false);

            GameObject tempo = GameObject.Find("Time");
            StopWatch timeScript = tempo.GetComponent<StopWatch>();
            timeScript.timerActive = false;

           // ScoreTexto.text = "Pontuação:" + Score;

        }
        
    }


    private void SelecionarPergunta()
    {
        val = Random.Range(0, perguntas.Count);
        perguntaSelecionada = perguntas[val];

        quizUI.SetPergunta(perguntaSelecionada);
        //quizUI.SetPergunta (perguntaSelecionada);
        //perguntas.RemoveAt(val);

    }

    public bool Resposta(string respondido)
    {
        bool respostaCorreta = false;
        if (respondido == perguntaSelecionada.respostaCorreta)
        {
            //Sim
            respostaCorreta = true;
            Score += 50;
            countPerguntas += 1;
            perguntas.RemoveAt(val);
           Debug.Log(Score);
        }
        else
        {
            countPerguntas += 1;
            //Não
        }

        Invoke("SelecionarPergunta", 0.4f);

        return respostaCorreta;
    }
}

[System.Serializable]

public class Pergunta
{
    public string infoPergunta;
    public TipoPergunta tipoPergunta;
    public Sprite perguntaImg;
    public AudioClip perguntaClip;
    public UnityEngine.Video.VideoClip perguntaVideoC;
    public List<string> opcoes;
    public string respostaCorreta;
}

[System.Serializable]
public enum TipoPergunta
{
    TEXT,
    IMAGE,
    VIDEO,
    AUDIO
}


