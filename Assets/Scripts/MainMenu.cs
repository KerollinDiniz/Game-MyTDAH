//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Scene cena;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void ChamaCena()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
    }

    public void ChamaCenaTemasHeroisIniciante()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    public void ChamaCenaTemasDinosIniciante()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase1Dinos");
    }

    public void ChamaCenaTemasPrincesasIniciante()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase1Princesas");
    }
    public void ChamaCenaInfo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Info");
    }
    public void ChamaCenaTemasHeroisAvancado()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemasAvancado");
    }
    public void ChamaCenaTemasHeroisAvancado1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameSceneAvancado");
    }


    public void VoltarCena()
    {
        
        cena = SceneManager.GetActiveScene();
        if (cena.name == "MenuModos")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
        }
        if (cena.name == "MenuTemas")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuModos");

        }
        if (cena.name == "MenuTemasAvancado")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuModos");

        }
        cena = SceneManager.GetActiveScene();
        if (cena.name == "Fase3Princesas")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
        }
        cena = SceneManager.GetActiveScene();
        if (cena.name == "Fase3Dinos")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
        }
        cena = SceneManager.GetActiveScene();
        if (cena.name == "Fase2")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
        }

        cena = SceneManager.GetActiveScene();
        if (cena.name == "MenuTemasAvancado")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
        }

        cena = SceneManager.GetActiveScene();
        if (cena.name == "Info")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
        }
        cena = SceneManager.GetActiveScene();
        if (cena.name == "Fase1Dinos")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
        }
        cena = SceneManager.GetActiveScene();
        if (cena.name == "Fase1Princesas")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
        }
        cena = SceneManager.GetActiveScene();
        if (cena.name == "Fase2Dinos")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
        }
        cena = SceneManager.GetActiveScene();
        if (cena.name == "Fase2Princesas")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
        }
        cena = SceneManager.GetActiveScene();
        if (cena.name == "GameScene")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
        }

        cena = SceneManager.GetActiveScene();
        if (cena.name == "Fase1")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuTemas");
        }

    }

}
