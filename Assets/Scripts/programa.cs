using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class programa : MonoBehaviour
{
    public int peso;
    public int distanciaEnKm;

    int precioPorHora;
    string vehiculo;
    float horas;
    float horasReales;
    bool todoCorrecto = true;
    // Start is called before the first frame update
    void Start()
    {

        // VERIFICACIONES
        if (peso < 100)
        {
            Debug.LogError("El peso minimo es 100k");
            todoCorrecto = false;
            Application.Quit();
        }
        if (peso > 10000)
        {
            Debug.LogError("El peso máximo es 10.000k");
            todoCorrecto = false;
            Application.Quit();
        }
        if (distanciaEnKm <= 0)
        {
            Debug.LogError("La distancia no puede ser menor a 1km");
            todoCorrecto = false;
            Application.Quit();
        }

        if (todoCorrecto == true)
        {
            // VER VEHICULO
            if (peso <= 2000)
            {
                precioPorHora = 3000;
                vehiculo = "Utilitario";
            }
            else if (peso <= 5000)
            {
                precioPorHora = 4500;
                vehiculo = "Pickup";
            }
            else if (peso <= 10000)
            {
                precioPorHora = 7000;
                vehiculo = "Camión";
            }


            // CALCULAR HS
            if (distanciaEnKm <= 50)
            {
                horas = 2f;
                horasReales = distanciaEnKm / 25f;
            }
            else
            {
                horas = distanciaEnKm / 25f;
                horas = horas + 1f;
                horasReales = distanciaEnKm / 25f;
            }

            Debug.Log($"Precio total: {horasReales} horas a ${precioPorHora} la hora en el vehículo {vehiculo} te sale ${precioPorHora * horas}");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
