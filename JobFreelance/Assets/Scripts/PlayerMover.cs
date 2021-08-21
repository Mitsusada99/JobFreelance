using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    //movimentação
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 MoveDirection;

   //Interagir 
    public bool EstaInteragindo { get; set; }

    //inventário
    [SerializeField]
    private List<string> _itemsDeInventario = new List<string>();

    void Update()
    {
        //movimentação
        ProcessInputs();

        //interagir
        if (Input.GetButtonDown("Interage")) EstaInteragindo = true;
        else EstaInteragindo = false;
        

    }


    void FixedUpdate()
    {
        Move();
    }


    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        MoveDirection = new Vector2(moveX, moveY).normalized;
    }


    void Move()
    {
        rb.velocity = new Vector2(MoveDirection.x * moveSpeed, MoveDirection.y * moveSpeed);
    }

    public void AdicionaItem(string nomeItem)
    {
        _itemsDeInventario.Add(nomeItem);
    }

    public bool TemItem(string nomeItem)
    {
        var resultado = _itemsDeInventario.Contains(nomeItem);
        return resultado;
    }
}
