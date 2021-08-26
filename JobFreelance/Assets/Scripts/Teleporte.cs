using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Teleporte : MonoBehaviour
{
    [SerializeField]

    private GameObject player;

    [SerializeField]

    private Vector3 local;

    //private Menu menu;

    public Animator transi; //animator da transição
    public float tempoTransi;

    public void Teletransportar()
    {
        StartCoroutine(Teleportar());
    }

    IEnumerator Teleportar()
    {
        transi.SetBool("trocar", true);

       yield return new WaitForSeconds(tempoTransi);
             
        player.transform.position = local;

        yield return new WaitForSeconds(1.35f);

        transi.SetBool("trocar", false);

    }
}
