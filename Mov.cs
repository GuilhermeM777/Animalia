using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.RightArrow)) {
       transform.Translate(0f, 0f, 0f);
    // Ambas as teclas estão sendo pressionadas, não faça nada (movimento anulado)
    
 } else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftArrow)) {
       transform.Translate(0f, 0f, 0f);
    // Ambas as teclas estão sendo pressionadas, não faça nada (movimento anulado)
    
 }  else if (Input.GetKey(KeyCode.D)) {
    // Apenas a tecla D está sendo pressionada, mova para a direita
    transform.Translate(0.01f, 0f, 0.0f);
} else if (Input.GetKey(KeyCode.RightArrow)) {
    // Apenas a tecla de seta para a esquerda está sendo pressionada, mova para a esquerda
    transform.Translate(0.01f, 0f, 0.0f);
}
else if (Input.GetKey(KeyCode.A)) {
    // Apenas a tecla D está sendo pressionada, mova para a direita
    transform.Translate(-0.01f, 0f, 0.0f);
} else if (Input.GetKey(KeyCode.LeftArrow)) {
    // Apenas a tecla de seta para a esquerda está sendo pressionada, mova para a esquerda
    transform.Translate(-0.01f, 0f, 0.0f);
} else if (Input.GetKey(KeyCode.Space)) {
    // Apenas a tecla de seta para a esquerda está sendo pressionada, mova para a esquerda
    transform.Translate(0.0f, 0.1f, 0.0f);
}
    // O Input.GetKey diz que quando a tecla for apertada, algo vai acontecer.
	// KeyCode."nome_da_tecla" serve pra botar qual teclar o GetKey vai pegar.
    
}
    }

