using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    [SerializeField] int edadUsuario;
    [SerializeField] float alturaUsuario;
    [SerializeField] bool esDonante;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario   + ", tengo " + edadUsuario + ",mido" + 
            alturaUsuario + "metros y es" + esDonante + "que soy donante de organos.");
        Debug.Log("Tengo " + edadUsuario + " años.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
