//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoFinal : MonoBehaviour
{
    [SerializeField] private GameObject tempo;
    [SerializeField] private Text tempoTexto;

    /* void Start()
     {
         tempoTexto.text = "";
     }*/

    // Update is called once per frame
    void Update()
    {
        GameObject tempo = GameObject.Find("Time");
        StopWatch timeScript = tempo.GetComponent<StopWatch>();
        //tempoTexto.text = "tempo: " + timeScript.timeStart.ToString("F2"); 
        tempo.SetActive(false);

        float minutes = Mathf.Floor(timeScript.timeStart / 60);

        float seconds = Mathf.RoundToInt(timeScript.timeStart % 60);

       

        if (minutes < 10)
        {
            tempoTexto.text = "Tempo: 0" + minutes + ":" + seconds;
        }
        if (seconds < 10)
        {
           tempoTexto.text = "Tempo: " + minutes + ":0" + seconds;
        }
        if (minutes < 10 && seconds<10)
        {
            tempoTexto.text = "Tempo: 0" + minutes + ":0" + seconds;
        }
        if (minutes >= 10 && seconds>=10 )
        {
            tempoTexto.text = "Tempo: " + minutes + ":" + seconds;
        }


    }
}
