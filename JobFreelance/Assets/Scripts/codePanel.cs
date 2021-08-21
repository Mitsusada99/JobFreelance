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

    // Update is called once per frame
    void Update()
    {
        textoDoCodigo.text = Codigo;

        if (Codigo == CodigoCorreto) //o que ele faz quando vc digita o codigo correto
        {
            abrirPorta.SetActive(true);
            //adicionar som quando abre
        }

        if (Codigo.Length >= 5) //zerar caso chegue no maximo de numeros
            Codigo = "";
    }

    public void AdicionarDigito(string digito) //poder digitar no painel
    {
        Codigo += digito;
    }
}
