using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo01 : MonoBehaviour
{
    [Header("Referências Gerais")]
    [SerializeField] private SpriteRenderer oSpriteRenderer;
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
        EspelharJogador();
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

    private void EspelharJogador()
    {
        if (inputHorizontal > 0)
        {
            oSpriteRenderer.flipX = false;
        }
        else if (inputHorizontal < 0)
        {
            oSpriteRenderer.flipX = true;
        }
    }
}
