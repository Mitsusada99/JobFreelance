using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private string cenaInicial;

    [SerializeField]
    private string fase2;

    //transi��o

    public Animator transi; //animator da transi��o
    public float tempoTransi;


    public void Sair()
    {
        StartCoroutine(CarregarSair());
    }

    public void Iniciar()
    {
        StartCoroutine(CarregarJogo());
    }

    public void Fase2()
    {
        StartCoroutine(CarregarFase2());
    }


    
    IEnumerator CarregarJogo()
    {
        transi.SetTrigger("Iniciar"); //tocar a anima��o

        yield return new WaitForSeconds(tempoTransi);

        SceneManager.LoadScene(cenaInicial);
    }

    IEnumerator CarregarSair()
    {
        transi.SetTrigger("Iniciar"); //tocar a anima��o

        yield return new WaitForSeconds(tempoTransi);

        Application.Quit();
    }

    IEnumerator CarregarFase2()
    {
        transi.SetTrigger("Iniciar"); //tocar a anima��o

        yield return new WaitForSeconds(tempoTransi);

        SceneManager.LoadScene(fase2);
    }
}
