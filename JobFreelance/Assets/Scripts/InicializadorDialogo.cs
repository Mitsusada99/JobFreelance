using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializadorDialogo : MonoBehaviour
{
    [SerializeField]
    private GerenciadorDeDialogo _gerenciador;

    [SerializeField]
    private Dialogo _dialogo;

    [SerializeField]
    private Dialogo _dialogoComCondicao;


    [SerializeField]
    private bool _deveChecarInventario;

    [SerializeField]
    private string _nomeDoItem1;

    [SerializeField]
    private string _nomeDoItem2;

    [SerializeField]
    private string _nomeDoItem3;


    [SerializeField]
    private PlayerMover _jogadorInterage;

    public void Inicializa()
    {
        if (_gerenciador == null)
            return;

        if (_deveChecarInventario)
        {
            if (_jogadorInterage.TemItem(_nomeDoItem1) && _jogadorInterage.TemItem(_nomeDoItem2) && _jogadorInterage.TemItem(_nomeDoItem3))
                _gerenciador.Inicializa(_dialogoComCondicao);
            else
                _gerenciador.Inicializa(_dialogo);

        }
        else
        {
            _gerenciador.Inicializa(_dialogo);
        }

        
    }
}
