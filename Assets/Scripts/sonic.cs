using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sonic : MonoBehaviour
{
	[SerializeField]
    Text message;

    void OnTriggerStay(Collider other)
    {
        message.text = "Sonic the Hedgehog es una serie de videojuegos publicados por Sega y por Sonic Team. Es uno de los personajes de videojuegos más reconocidos del mundo. A partir de 2013, la franquicia ha vendido más de 360 millones de unidades, siendo la quinta saga de videojuegos más vendida de todos los tiempos.";
    }
    private void OnTriggerExit(Collider other){
        message.text = "";
    }
}
