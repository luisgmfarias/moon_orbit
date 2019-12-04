using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotacao : MonoBehaviour{

    private float velocidade;
    public float velocidadeMin, velocidadeMax;

    public Slider velocidade_slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocidade_slider.minValue = velocidadeMin;
        velocidade_slider.maxValue = velocidadeMax;
        velocidade = velocidade_slider.value;
        transform.Rotate(0,velocidade*Time.deltaTime,0);
    }
}
