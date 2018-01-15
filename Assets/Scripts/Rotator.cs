/////////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Ramón Guardia
// Curso: 2017/2018
// Fichero: Rotator.cs
/////////////////////////////////////////
using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{

    /// <summary>
    /// Método encargado de gestionar la rotación de los
    /// cubos
    /// </summary>
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}