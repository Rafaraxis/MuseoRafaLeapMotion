using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mario : MonoBehaviour
{
	[SerializeField]
    Text message;

    void OnTriggerStay(Collider other)
    {
        message.text = "Mario (マリオ?) es un personaje ficticio de la franquicia de videojuegos homónima diseñado por el japonés Shigeru Miyamoto para la compañía Nintendo. Con su aparición en videojuegos, series televisivas y películas, se ha posicionado como el ícono emblemático de Nintendo, llegando a ser uno de los personajes más famosos y conocidos de videojuegos de todos los tiempos, junto a su hermano menor Luigi, quien es su compañero ícono en diversos juegos y lo ayuda a cumplir su misión.Originalmente, Mario fue bautizado con el nombre de Jumpman («hombre saltarín» en inglés) y apareció por primera vez en el videojuego Donkey Kong del año 1981, pero en 1983 su nombre cambió al conocido actualmente como Mario, en homenaje al nombre del propietario de las primeras oficinas de Nintendo of América, Mario Segale en ese tiempo, y de su singular parecido al personaje. Mario fue creado para ser un personaje de videojuegos de plataforma de dos dimensiones (2D), como Super Mario Bros., Super Mario Land, Super Mario World, etc; pero también tiene videojuegos tridimensionales (3D), como por ejemplo Super Mario 64, Super Mario Sunshine, Super Mario Galaxy, Super Mario Odyssey, etc. También aparece en juegos que no son del género de plataformas, como en las series Mario Kart, Mario Party, Paper Mario, Super Smash Bros., etc.";
    }
    private void OnTriggerExit(Collider other){
        message.text = "";
    }
	
}
