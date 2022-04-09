using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondaasteroide : MonoBehaviour
{ 
    public compeortamentoAsteerroide prrefabAsteroide;
    public int quantidadeeasteroide = 3;
    
    void Start()
    {
        for(int i = 0; i <quantidadeasteroide, i++);
        vector3 pposicao = new vector3(0,0f,0,0f,0,0f);
        instantiate(preffaAsteroide, posicao, quaternion.Indentity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
