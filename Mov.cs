using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    public float jumpCooldown = 0.01f; // tempo de cooldown em segundos
    public float nextJumpTime = -0.1f; // tempo do próximo pulo permitido

     public float forwardSpeed = 3f;


    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
          rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.RightArrow)) {
       transform.Translate(0.0f, 0f, 0f);
    // Ambas as teclas estão sendo pressionadas, não faça nada (movimento anulado)
    
 }   if (Input.GetKey(KeyCode.RightArrow) ^ Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.Space) && Time.time > nextJumpTime)
        {
            // Move para frente
            transform.Translate(Vector3.right * forwardSpeed * Time.deltaTime);
            // Aplica a força de pulo
            transform.Translate(0f, 0.2f, 0f);
            
            nextJumpTime = Time.time - jumpCooldown;
        }
       if (Input.GetKey(KeyCode.LeftArrow) ^ Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Space) && Time.time > nextJumpTime)
        {
            // Move para frente
            transform.Translate(-Vector3.right * forwardSpeed * Time.deltaTime);
            // Aplica a força de pulo
            transform.Translate(0f, 0.2f, 0f);
            
            nextJumpTime = Time.time - jumpCooldown;
        }  else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftArrow)) {
       transform.Translate(0f, 0f, 0f);
    // Ambas as teclas estão sendo pressionadas, não faça nada (movimento anulado)
    
 }  else if (Input.GetKey(KeyCode.D) ^ Input.GetKey(KeyCode.RightArrow)) {
    // Apenas a tecla D está sendo pressionada, mova para a direita
    transform.Translate(0.019f, 0f, 0.0f);
} 
  else if (Input.GetKey(KeyCode.A) ^ Input.GetKey(KeyCode.LeftArrow)) {
    // Apenas a tecla D está sendo pressionada, mova para a direita
    transform.Translate(-0.019f, 0f, 0.0f); }
  else if (Input.GetKey(KeyCode.Space) && Time.time > nextJumpTime)
        {
            // Aplica a força de pulo
            transform.Translate(0f, 0.2f, 0f);
            
            nextJumpTime = Time.time - jumpCooldown;
        } 
 
    // O Input.GetKey diz que quando a tecla for apertada, algo vai acontecer.
	// KeyCode."nome_da_tecla" serve pra botar qual teclar o GetKey vai pegar.

}
    }

