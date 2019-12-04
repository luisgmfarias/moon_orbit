using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrastar_objeto : MonoBehaviour{
    Vector3 deslocamento;

    private void OnMouseDown(){
        deslocamento = this.transform.position - CoordMouseNoMundo();
    }

    Vector3 CoordMouseNoMundo(){
        Vector3 coordMouseNaTela = Input.mousePosition;
        coordMouseNaTela.z = Camera.main.WorldToScreenPoint(this.transform.position).z;
        return Camera.main.ScreenToWorldPoint(coordMouseNaTela);
    }

    private void OnMouseDrag(){
        this.transform.position = CoordMouseNoMundo() + deslocamento;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
