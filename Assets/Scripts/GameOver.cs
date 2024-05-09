using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static int paresSpawns;
    public static int imparesSpawns;
    
    int paresCollision;
    int imparesCollision;

    public static bool parCalc;
    public static bool imparCalc;
        
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;

    
    void Start()
    {
        
    }    

    void Update()
    {
        //Debug.Log("paresSpawn: " + paresSpawns);

        if (imparCalc == true)
        {
            Debug.Log("Calculo Impar");
            //ideal fazer switch 1,
            if (imparesCollision == imparesSpawns)
            {

                Time.timeScale = 1f;
            }
        }

        if (parCalc == true)
        {
            Debug.Log("Calculo Par");
            if (paresCollision == paresSpawns)
            {

                Time.timeScale = 1f;
            }
        }

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Par"))
        {
            paresCollision++;
            Debug.Log("Pares que cairam: " + paresCollision);
        }

        if (collision.gameObject.CompareTag("Impar"))
        {
            imparesCollision++;
            Debug.Log("Impares que cairam: " + imparesCollision);
        }
    }
}
