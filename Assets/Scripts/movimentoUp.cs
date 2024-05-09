using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movimentoUp : MonoBehaviour
{

    int forceUp;
    Rigidbody2D rig;

    private int valorNumero;

    public static bool cutting = false;

    public GameObject ativaPar;
    public GameObject ativaImpar;
    public GameObject particulas;


    public bool upper;
    public GameObject numMesh;
    public Text front;
    public Text right;
    public Text down;

    public int minForce;
    public int maxForce;

    private void Awake()
    {
        particulas.SetActive(false);
    }

    void Start()
    {
        valorNumero = Random.Range(1, 10);
        front.text = "" + valorNumero;
        right.text = "" + valorNumero;
        down.text = "" + valorNumero;


        if (upper)
        {
            forceUp = Random.Range(minForce, maxForce);
            cutting = false;
            rig = GetComponent<Rigidbody2D>();
            rig.AddForce(transform.up * forceUp, ForceMode2D.Impulse);
        }
        
        EParImpar();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Blade" && cutting == true)
        {
            
            NovoSpawner.numClicado = valorNumero;
            ScoreMax.clicouNum = true;
            //Calculos.numeroClicado = valorNumero;
            NovoSpawner.clicou = true;
            numMesh.SetActive(false);
            this.particulas.SetActive(true);

            // Adicionar particulas
            StartCoroutine(Destruir());
        }
    }

    void EParImpar()
    {

        if (valorNumero % 2 == 0)
        {
            Debug.Log("O numero é par");
            ativaImpar.SetActive(false);
            GameOver.paresSpawns++;
        }
        else
        {
            Debug.Log("O numero é impar");
            ativaPar.SetActive(false);
            GameOver.imparesSpawns++;
        }
    }

    IEnumerator Destruir()
    {

        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
        Debug.Log("CHAMOU DESTRUIR");
        
    }
}
