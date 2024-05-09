using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovoSpawner : MonoBehaviour
{
    public GameObject objeto;
    public Transform[] spawnPoints;

    public GameObject botãoAtiva;
    public GameObject calcImpares;
    public GameObject calcPares;

    public float minSpawDelay = 0.5f;
    public float maxSpawDelay = 1f;

    private int contador;

    private int numClic;
    public static int numClicado;
    public static bool clicou = false;
    public int calculo;

    public bool ativaPar;
    public bool ativaImpar;

    void Start()
    {        
        contador = 0;
        ativaImpar = false;
        ativaPar = false;
    }


    public void Ativa()
    {
        Calculo();        
        ParImpar();
        botãoAtiva.SetActive(false);
        contador = 0;
        StartCoroutine(Spawn());        
    }

    public void Calculo()
    {
        //Randomiza o calculo ( 1 é par, 2 é impar)
        calculo = Random.Range(1,3);
        if (calculo == 1)
        {
            ativaPar = true;
        }
        if (calculo == 2)
        {
            ativaImpar = true;
        }
    }

    public IEnumerator Spawn()
    {
        while (contador <= 9) 
        {
            float Timer = Random.Range(minSpawDelay, maxSpawDelay);
            yield return new WaitForSeconds(1f);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            GameObject spawnedObjeto = Instantiate(objeto, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnedObjeto, 5f);
                                    
            contador++;

            if (contador >= 10)
            {
                yield return new WaitForSeconds(5f);

                botãoAtiva.SetActive(true);
                GameOver.parCalc = false;
                GameOver.imparCalc = false;
                ativaPar = false;
                ativaImpar = false;
            }
        }        
    }

    void Update()
    {
        if (numClicado >= 1)
        {
            //VerificaClicado();
            numClic = numClicado;

            if (clicou == true)
            {
                Debug.Log("Verificando");
                VerificaClicado();
            }
        }
    }


    void ParImpar()
    {

        if (calculo == 1)
        {            
            if (ativaPar == true)
            {
                GameOver.parCalc = true;
                GameOver.imparCalc = false;
                calcImpares.SetActive(false);
                calcPares.SetActive(true);
                Debug.Log("Calculo Pares");
            }            
        }

        if (calculo == 2)
        {
            if (ativaImpar == true)
            {
                calcImpares.SetActive(true);
                calcPares.SetActive(false);
                GameOver.parCalc = false;
                GameOver.imparCalc = true;
                Debug.Log("Calculo Impares");
            }            
        }
    }

    void VerificaClicado()
    {
        if (calculo == 1)
        {
            if (numClic % 2 == 0 && numClic != 0)
            {
                Debug.Log("O numero é par" + numClic);
                ScoreMax.valorScore = +1;
            }
            else
            {
                Debug.Log("O numero é impar");
                ScoreMax.valorScore = -1;
            }
            clicou = false;
        }

        if (calculo == 2)
        {
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
