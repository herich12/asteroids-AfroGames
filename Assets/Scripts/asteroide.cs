using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroide : MonoBehaviour
{
    pubblic Rigidbudy2D asteroidRb;
    Public Float velocidadeMaxima = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 derecao = ramdom.insideUnitCircle;
        direcao = direcao * velocidadeMaxiuma; //direcao *= velocidadeMaxima
        asteroidRb.velocity = direcao;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
