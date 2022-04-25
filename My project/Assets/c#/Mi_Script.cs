using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi_Script : MonoBehaviour
{
    public string bienvenido_mi_mundo;
    public string mi_nombre;
    public string nombre_de_mi_amigo;
    public int edad ;
    public int edad_de_mi_amigo;
    public bool estaarriba;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hola mundo, como estas?" + mi_nombre );
        Debug.Log(" nos llamamos" + mi_nombre);
        Debug.Log(" nos llamamos" + nombre_de_mi_amigo);
        Debug.Log(  17 );
        Debug.Log( edad_de_mi_amigo  );
        Debug.Log( edad  + edad_de_mi_amigo );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Omjump()
    {

    }
}
