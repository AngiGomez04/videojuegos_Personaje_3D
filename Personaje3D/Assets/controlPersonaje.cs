using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPersonaje: MonoBehaviour
{

    // Animator controller
    public float velocidadP = 3.0f;
    public float rotateP = 50.0f;
    public float px, py;
    private Animator miAnim;

    // Start is called before the first frame update
    void Start()
    {
        miAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //capturar los eventos del teclado

        px = Input.GetAxis("Horizontal");
        py = Input.GetAxis("Vertical");

        transform.Translate(0, 0, py * Time.deltaTime * velocidadP);

        //Acceder a los parametros del controller

        miAnim.SetFloat("velX", px);
        miAnim.SetFloat("velY", py);

        //Calcular el desplazamiento para girar

        transform.Rotate(0, px * Time.deltaTime * rotateP, 0);


        //Acceder a los parametros del controller

        miAnim.SetFloat("velX", px);
        miAnim.SetFloat("velY", py);


    }
}
