/////////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Ramón Guardia
// Curso: 2017/2018
// Fichero: CameraController.cs
/////////////////////////////////////////
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    /// <summary>
    /// Método encargado de inicializar los componentes
    /// </summary>
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    /// <summary>
    /// En el método LateUpdate, situamos la cámara correctamente
    /// con respecto a la esfera
    /// </summary>
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}