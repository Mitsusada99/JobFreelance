using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Collider2D))] //ele avisa a necessidade de um collider para funcionar
public class InteragirComBotao : MonoBehaviour
{
    [SerializeField]
    private PlayerMover _jogadorInterage; //utilizo essa variavel para acessar coisas no script do jogador
                                          

    [SerializeField]
    private UnityEvent _botaoApertado; //unity event é algo que facilita a realização de ações pelo inspector

    private bool _podeExecutar;

    //inventário
    [SerializeField]
    private bool _deveChecarInventario;

    [SerializeField]
    private string _nomeDoItem;

    // Update is called once per frame
    void Update()
    {
        if(_podeExecutar && _jogadorInterage.EstaInteragindo == true)
        {
            if(_deveChecarInventario)
            {
                if (_jogadorInterage.TemItem(_nomeDoItem))
                    _botaoApertado.Invoke();
            }
            else 
            {
                _botaoApertado.Invoke();
            }

        }

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _podeExecutar = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _podeExecutar = false;
    }
}
