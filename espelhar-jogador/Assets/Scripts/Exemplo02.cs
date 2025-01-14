using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo02 : MonoBehaviour
{
    [Header("Referências Gerais")]
    private Rigidbody2D oRigidbody2D;

    [Header("Movimentação")]
    [SerializeField] private float velocidadeDeMovimento = 8.0f;
    private float inputHorizontal = 0.0f;

    private void Start()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ReceberInputs();
    }

    private void ReceberInputs()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        MovimentarJogador();
    }

    private void MovimentarJogador()
    {
        oRigidbody2D.velocity = new Vector2(inputHorizontal * velocidadeDeMovimento, oRigidbody2D.velocity.y);
    }
}
