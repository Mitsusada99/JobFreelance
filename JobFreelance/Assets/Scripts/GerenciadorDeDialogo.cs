using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GerenciadorDeDialogo : MonoBehaviour
{
    //variaveis que vamos utilizar para acessar os textos
    [SerializeField]
    private TextMeshProUGUI _nomeNpc;   //quando queremos acessar pelo inspector, mas ainda sim mantermos a variável

    private int _contador = 0;
    private Dialogo _dialogoAtual;

    internal void Inicializa(Dialogo dialogo)
    {
        _contador = 0;
        _dialogoAtual = dialogo;

        ProximaFrase();
    }

    public void ProximaFrase()
    {
        if (_dialogoAtual == null)
            return;

        if(_contador == _dialogoAtual.GetFrases().Length)
        {
            _caixaDialogo.gameObject.SetActive(false);
            _dialogoAtual.RealizaAcao();
            _dialogoAtual = null;
            _contador = 0;
            return;

        }


        _nomeNpc.text = _dialogoAtual.GetNomeNPC();
        _texto.text = _dialogoAtual.GetFrases()[_contador].GetFrase();
        _btnContinua.text = _dialogoAtual.GetFrases()[_contador].GetBotaoContinuar();
        _caixaDialogo.gameObject.SetActive(true);
        _contador++;

    }

    //privada, utilizamos o serialize field  
    [SerializeField]
    private TextMeshProUGUI _texto;

    [SerializeField]
    private TextMeshProUGUI _btnContinua;

    [SerializeField]
    private GameObject _caixaDialogo;

}
