using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandom : MonoBehaviour
{
    public Color[] cores;
    //public ParticleSystem particulas;
    public Color cor;

    void Start()
    {
        Color c = cores[Random.Range(0, cores.Length - 1)];
        GetComponent<Renderer>().material.color = c;
        //cor = c;
        //particulas.GetComponent<Renderer>().material.color = cor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
