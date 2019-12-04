using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarTam : MonoBehaviour{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)){
            Vector3 newScale = transform.localScale;
            newScale *=1.2f;
            transform.localScale = newScale;
        }
        if (Input.GetKey(KeyCode.LeftControl)){
            Vector3 newScale = transform.localScale;
            newScale /=1.2f;
            transform.localScale = newScale;
        }
        
    }
}
