using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private QuizManager quizManager;
    [SerializeField] private Text perguntaTexto;
    [SerializeField] private Image perguntaImagem;
    [SerializeField] private UnityEngine.Video.VideoPlayer perguntaVideo;
    [SerializeField] private AudioSource perguntaAudio;
    [SerializeField] private List<Button> opcoes;
    [SerializeField] private Color corCorreta, corErrada, corNormal;
    [SerializeField] private Text ScoreTexto;
    [SerializeField] private int Score;


    private Pergunta pergunta;
    private bool respondido = false;
    private float audioLength;
    private AudioSource audioRespostaCorreta;
    private AudioSource audioRespostaErrada;
 



    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < opcoes.Count; i++)
        {
            Button localBtn = opcoes[i];
            localBtn.onClick.AddListener(() => OnClick(localBtn));

        }

        ScoreTexto.text = "Pontuação:";


        //playerScript.Health -= 10.0f;
        audioRespostaCorreta = GameObject.FindGameObjectWithTag("Correta").GetComponent<AudioSource>();
        audioRespostaErrada = GameObject.FindGameObjectWithTag("Errada").GetComponent<AudioSource>();

    }

    void Update()
    {
        GameObject QuizManager = GameObject.Find("QuizManager");
        QuizManager playerScript = QuizManager.GetComponent<QuizManager>();
        Score = playerScript.Score;
        ScoreTexto.text = "Pontuação:" + Score;
        Debug.Log(Score);
    }

    public void SetPergunta(Pergunta pergunta)
    {
        this.pergunta = pergunta;

        switch (pergunta.tipoPergunta)
        {
            case TipoPergunta.TEXT:

                perguntaImagem.transform.parent.gameObject.SetActive(false);

                break;

            case TipoPergunta.IMAGE:
                ImagemControle();
                perguntaImagem.transform.gameObject.SetActive(true);

                perguntaImagem.sprite = pergunta.perguntaImg;
                break;

            case TipoPergunta.VIDEO:
                ImagemControle();
                perguntaVideo.transform.gameObject.SetActive(true);

                perguntaVideo.clip = pergunta.perguntaVideoC;
                perguntaVideo.Play();
                break;

            case TipoPergunta.AUDIO:
                ImagemControle();
                perguntaAudio.transform.gameObject.SetActive(true);

                audioLength = pergunta.perguntaClip.length;

                StartCoroutine(PlayAudio());
                break;

        }

        perguntaTexto.text = pergunta.infoPergunta;

        List<string> respostaList = ShuffleList.ShuffleListItems<string>(pergunta.opcoes);

        for (int i = 0; i < opcoes.Count; i++)
        {
            opcoes[i].GetComponentInChildren<Text>().text = respostaList[i];
            opcoes[i].name = respostaList[i];
            opcoes[i].image.color = corNormal;
        }

        respondido = false;
    }


    IEnumerator PlayAudio()
    {
        if (pergunta.tipoPergunta == TipoPergunta.AUDIO)
        {
            perguntaAudio.PlayOneShot(pergunta.perguntaClip);
            yield return new WaitForSeconds(audioLength + 0.5f);

            StartCoroutine(PlayAudio());
        }
        else
        {
            StopCoroutine(PlayAudio());
            yield return null;
        }
    }

    void ImagemControle()
    {
        perguntaImagem.transform.parent.gameObject.SetActive(true);
        perguntaImagem.transform.gameObject.SetActive(false);
        perguntaAudio.transform.gameObject.SetActive(false);
        perguntaVideo.transform.gameObject.SetActive(false);

    }

    private void OnClick(Button btn)
    {
        if (!respondido)
        {
            respondido = true;
            bool val = quizManager.Resposta(btn.name);

            if (val)
            {
                btn.image.color = corCorreta;
                audioRespostaCorreta.Play();

            }
            else
            {
                btn.image.color = corErrada;
                audioRespostaErrada.Play();
            }
        }
    }

}

