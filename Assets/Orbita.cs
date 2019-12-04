using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Orbita : MonoBehaviour{
    
    public Transform alvo;
    public Vector3 direcao;

    public float velocidadeMin, velocidadeMax;
    public float distanciaMin, distanciaMax;

    public Slider velocidade_slider;
    public Slider distancia_slider;
    private float velocidade;
    private float distancia;

    void Start(){

    }

    void Update(){

        //Controle de Slider//
        velocidade_slider.minValue = velocidadeMin;
        velocidade_slider.maxValue = velocidadeMax;
        distancia_slider.minValue = distanciaMin;
        distancia_slider.maxValue = distanciaMax;

        velocidade = velocidade_slider.value;
        distancia = distancia_slider.value;

        transform.RotateAround(alvo.position, direcao, velocidade);

        Vector3 posDesejada = (transform.position - alvo.position).normalized * distancia + alvo.position;
        transform.position = Vector3.Lerp(transform.position,posDesejada, 5*Time.deltaTime);
    }
}
