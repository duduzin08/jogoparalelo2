using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class cenario : MonoBehaviour

{
    //variavel para controlar o objeto
    public float velocidade = 1.0f;
    // variavel para controle de reposição
    public float reposicao = 18.0f;
    // variavel para guardar a posição inicial do objeto
    public Vector3 posicaoInicial;




   





    // Start is called before the first frame update

    void Start()

    {

        posicaoInicial = transform.position ;

    }




    // Update is called once per frame

    void Update()

    {

        float novaPosicao = Mathf.Repeat(Time.time * velocidade,reposicao);

        transform.position = posicaoInicial + Vector3.down * novaPosicao;

    }

}