using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndasAsteroide : MonoBehaviour
{
    public comportamentoAsteroide prefabAsteroide; //Declaração do componente de Script (pega o prefab)
    public int quantidadeAsteroides = 100;

    void Start()
    {
        for (int i = 0; i < quantidadeAsteroides; i++) //Laço de Repetição 'for'(ESTUDEM!!!)
        {
            float x = Random.Range(-9.5f, 9.5f);
            float y = Random.Range(-5.0f, 5.0f);
            Vector3 posicao = new Vector3(0.0f, 0.0f, 0.0f);
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }
}