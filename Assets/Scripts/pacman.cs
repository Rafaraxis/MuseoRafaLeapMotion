using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pacman : MonoBehaviour
{
	[SerializeField]
    Text message;

    void OnTriggerStay(Collider other)
    {
        message.text = "Pac-Man es un videojuego arcade creado por el diseñador de videojuegos Toru Iwatani de la empresa Namco, y distribuido por Midway Games al mercado estadounidense a principios de los años 1980. Desde que Pac-Man fue lanzado el 21 de mayo de 1980, fue un éxito.";
    }
    private void OnTriggerExit(Collider other){
        message.text = "";
    }
}
