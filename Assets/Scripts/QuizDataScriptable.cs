//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PerguntaData", menuName = "PerguntaData", order = 1)]
public class QuizDataScriptable : ScriptableObject
{
    public List<Pergunta> perguntas;
    public string categoryName;

}