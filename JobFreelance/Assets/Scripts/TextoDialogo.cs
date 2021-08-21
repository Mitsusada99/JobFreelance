using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TextoDialogo 
{
    [SerializeField]
    [TextArea(1,4)]
    private string _frase;

    [SerializeField]
    private string _btnContinuar;
    public string GetFrase()
    {
        return _frase;
    }

    public string GetBotaoContinuar()
    {
        return _btnContinuar;
    }

    //n�o herda de monobehaviour pois n�o queremos definir nenhum comportamento pro dialogo
   
}
