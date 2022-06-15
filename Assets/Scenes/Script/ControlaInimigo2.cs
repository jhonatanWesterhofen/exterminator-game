/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo2 : MonoBehaviour
{
    public Alvo alvoOrigem;
    private float tempoDecorrido;

    // Start is called before the first frame update
    void Start()
    {
        this.tempoDecorrido = 0;
    }

    // Update is called once per frame
    void Update()
    {
      this.tempoDecorrido += Time.deltaTime;  
      if (this.tempoDecorrido >= 1f){
          this.tempoDecorrido = 0;

          Vector2 posicaoMax = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
          Vector2 posicaoMin = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

          float posicaoX = Random.Range(posicaoMin.x, posicaoMax.x);
          Vector2 posicaoInimigo2 = new Vector2(posicaoX, posicaoMax.y );
          //novo maluco
          Instantiate(this.alvoOrigem, posicaoInimigo2, Quaternion.identity);
      }
    }
}
*/