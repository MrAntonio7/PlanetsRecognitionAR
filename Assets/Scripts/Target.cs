using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    //Array de objetos
    public GameObject[] arrayObjects;

    //Tiempo que dura un planeta 5s
    float repeatTime = 5f;

    //Tiempo que pasa entre un frame y otro
    float elapsedTime = 0f;

    //index del array
    private int currentIndex = 0;

    public TMP_Text textoPlanetas;
    public TMP_Text puntosPlanetas;

    public int puntos;

    private bool sumado;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject planeta in arrayObjects)
        {
            planeta.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= repeatTime)
        {
            //Genera un objeto random
            NewRandomObject();
            
            Debug.Log("Generando nuevo planeta con nuevo index");

            //Reinicia lo que tarde entre un frame y otro
            elapsedTime = 0f;
        }
    }

    public void NewRandomObject()
    {
        Debug.Log("Desactivando y generando random");
        sumado = false;
        //Desactiva el objeto activo
        arrayObjects[currentIndex].SetActive(false);
        //Genera un index random
        int randomIndex = Random.Range(0, arrayObjects.Length);
        Debug.Log("Index generado es " + randomIndex);

        //Activa el objeto nuevo
        arrayObjects[randomIndex].SetActive(true);
        //Guarda el indice del array del numero random generado
        currentIndex = randomIndex;

        //Cambia el texto por cada planeta
        Debug.Log("index El nombre del planeta generado es " + arrayObjects[currentIndex].name);
        textoPlanetas.text = arrayObjects[currentIndex].name;
       


    }

    public void SumaPuntos()
    {
        if (!sumado)
        {
            puntos++;
            puntosPlanetas.text = "Puntos: " + puntos.ToString();
            sumado=true;
        }
        
    }


}
