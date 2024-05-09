using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoNumero : MonoBehaviour
{

    public float speedDown;
    public float timeLife;
    public int valorNum;
    public static int numeroValor;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speedDown * Time.deltaTime);
        //StartCoroutine(Destruir());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Blade")
        {
            //Debug.Log("colidiu");
            Destroy(this.gameObject);
            numeroValor = valorNum;
            Debug.Log("O numero Clicado foi" + numeroValor);
            Calculos.numeroClicado = numeroValor;
            ParesEImpares.numClicado = numeroValor;
            Calculos.clicou = true;
            ParesEImpares.clicou = true;
            ScoreMax.clicouNum = true;
            
        }
        
    }
    IEnumerator Destruir()
    {
        yield return new WaitForSeconds(timeLife);
        Destroy(this.gameObject);
    }
}
