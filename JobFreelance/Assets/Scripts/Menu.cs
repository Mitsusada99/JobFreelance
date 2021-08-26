using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private string cenaInicial;

    //transição

    public Animator transi; //animator da transição
    public float tempoTransi;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sair()
    {
        StartCoroutine(CarregarSair());
    }

    public void Iniciar()
    {
        StartCoroutine(CarregarJogo());
    }


    
    IEnumerator CarregarJogo()
    {
        transi.SetTrigger("Iniciar"); //tocar a animação

        yield return new WaitForSeconds(tempoTransi);

        SceneManager.LoadScene(cenaInicial);
    }

    IEnumerator CarregarSair()
    {
        transi.SetTrigger("Iniciar"); //tocar a animação

        yield return new WaitForSeconds(tempoTransi);

        Application.Quit();
    }
}
