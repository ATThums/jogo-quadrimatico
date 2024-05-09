using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParesEImpares : MonoBehaviour
{
    int numClic;
    public static int numClicado;
    public static bool clicou = false;
    public bool pares;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (numClicado >= 1)
        {
            numClic = numClicado;
            Debug.Log("O numClic foi" + numClic);
            // numeroClicado = MovimentoNumero.numeroValor;

            if (clicou == true)
            {
                ParImpar();

            }
        }
        
    }


    void ParImpar()
    {

        if(pares == true)
        {
            Debug.Log("Calculo Pares");
            if (numClic % 2 == 0 && numClic != 0)
            {
                Debug.Log("O numero é par");
                ScoreMax.valorScore = +1;
            }
            else
            {
                Debug.Log("O numero é impar");
                ScoreMax.valorScore = -1;
            }
            clicou = false;
        }

        if (pares == false)
        {
            Debug.Log("Calculo Impares");
            if (numClic % 2 == 0 && numClic != 0)
            {
                Debug.Log("O numero é par");
                ScoreMax.valorScore = -1;
            }
            else
            {
                Debug.Log("O numero é impar");
                ScoreMax.valorScore = +1;
            }
            clicou = false;
        }

    }
}
