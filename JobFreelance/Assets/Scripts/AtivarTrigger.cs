using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Collider2D))] //ele avisa a necessidade de um collider para funcionar
public class AtivarTrigger : MonoBehaviour
{

    [SerializeField]
    private UnityEvent _interagir; //unity event � algo que facilita a realiza��o de a��es pelo inspector


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _interagir.Invoke();
    }

}

