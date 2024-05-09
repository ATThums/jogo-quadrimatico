using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Calculos : MonoBehaviour
{
    int resultado;
    int numClic;
    int primeiroValor;
    int segundoValor;
    public static int numeroClicado;
    public Text simbolCalc;
    public Text primValor;
    public Text segValor;

    public static bool clicou = false;



    int calculo;


    void Start()
    {
        //resultadoCalc = resultado.ToString;
        Resultado();
    }

    void Update()
    {
                
        numClic = numeroClicado;
        Debug.Log("O numClic foi" + numClic);
        // numeroClicado = MovimentoNumero.numeroValor;

        if (clicou == true)
        {            
            VerificarCalculo();
            Resultado();
        }
        
    }

    void VerificarCalculo()
    {
        if (numClic == resultado)
        {
            ScoreMax.valorScore = +1;
        }

        else if (numClic != resultado)
        {
            ScoreMax.valorScore = -1;
        }
        clicou = false;
        Debug.Log("O numero Clicado/resultado foi" + numClic);
    }


    public void Resultado()
    {
        resultado = Random.Range(1, 10);
        calculo = Random.Range(1, 3);

        //Calculo de soma

        if (calculo == 1)
        {
            simbolCalc.text = "+";
            primeiroValor = Random.Range(0, resultado);
            segundoValor = resultado - primeiroValor;
            primValor.text = "" + primeiroValor;
            segValor.text = "" + segundoValor;
            Debug.Log("O resultado é: " + resultado);
            Debug.Log("O calculo é: " + calculo);
            Debug.Log("O primeiro valor é: " + primeiroValor);
            Debug.Log("O segundo valor é: " + segundoValor);
        }
        //Calculo de subtracao
        else if (calculo == 2)
        {
            simbolCalc.text = "-";
            primeiroValor = Random.Range(resultado, 9);
            segundoValor = primeiroValor - resultado;
            primValor.text = "" + primeiroValor;
            segValor.text = "" + segundoValor;
            Debug.Log("O resultado é: " + resultado);
            Debug.Log("O calculo é: " + calculo);
            Debug.Log("O primeiro valor é: " + primeiroValor);
            Debug.Log("O segundo valor é: " + segundoValor);
        }
                

        /*//Calculo de multiplicação
        if (calculo == 3)
        {
            primeiroValor = Random.Range(0, resultado);
            segundoValor = resultado - primeiroValor;
            Debug.Log("O resultado é: " + resultado);
            Debug.Log("O calculo é: " + calculo);
            Debug.Log("O primeiro valor é: " + primeiroValor);
            Debug.Log("O segundo valor é: " + segundoValor);
        }
        //Calculo de divisao
        else if (calculo == 4)
        {
            primeiroValor = Random.Range(resultado, 9);
            segundoValor = primeiroValor - resultado;
            Debug.Log("O resultado é: " + resultado);
            Debug.Log("O calculo é: " + calculo);
            Debug.Log("O primeiro valor é: " + primeiroValor);
            Debug.Log("O segundo valor é: " + segundoValor);
        }*/
    }

}
