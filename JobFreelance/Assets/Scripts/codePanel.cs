using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codePanel : MonoBehaviour
{

    [SerializeField]
    Text textoDoCodigo;

    string Codigo = "";

    [SerializeField]
    private string CodigoCorreto;

    [SerializeField]
    private GameObject abrirPorta;

    [SerializeField]
    private GameObject desligarDialogo;

    bool botaoApertado; //checa se a pessoa apertou o botão de confirmar

    //Sons 

    [SerializeField]
    private AudioSource somAcerto;

    [SerializeField]
    private AudioSource somErro;
    // Update is called once per frame
    void Update()
    {
        textoDoCodigo.text = Codigo;

        if (botaoApertado)
            if (Codigo == CodigoCorreto) //o que ele faz quando vc digita o codigo correto
            {
                abrirPorta.SetActive(true);
                //adicionar som quando abre

                desligarDialogo.SetActive(false);
                //desligar o dialogo da porta fechada

               // somAcerto.Play();
                this.gameObject.SetActive(false);
                botaoApertado = false;
            }
            else
            {
               // somErro.Play();
                botaoApertado = false;
                Codigo = "";
            }


       // if (Codigo.Length >= 5) //zerar caso chegue no maximo de numeros
          //  Codigo = "";
    }

    public void AdicionarDigito(string digito) //poder digitar no painel
    {
        Codigo += digito;
    }

    public void Checar()
    {
        botaoApertado = true;
    }

    public void Apagar()
    {
         Codigo = "";
    }
}
