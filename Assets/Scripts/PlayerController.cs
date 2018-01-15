/////////////////////////////////////////
// Práctica: Roll-a-ball
// Alumno/a: Ramón Guardia
// Curso: 2017/2018
// Fichero: PlayerController.cs
/////////////////////////////////////////
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    /// <summary>
    /// Método encargado de inicializar los componentes
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    /// <summary>
    /// En el método FixedUpdate creamos el movimiento de
    /// la esfera
    /// </summary>
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    /// <summary>
    /// Método encargado de hacer que los cubos desaparezcan
    /// al colisionar
    /// </summary>
    /// <remarks>
    /// Se encargará de hacer desaparecer cada cubo creando el
    /// efecto de colisión. Por otra parte, el contador de cubos
    /// destruidos se incrementa, llamando al método SetCountText
    /// </remarks>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    /// <summary>
    /// Método encargado de gestionar la cuenta de objetos
    /// colisionados pasando todo a String
    /// <remarks>
    /// El método pondrá todo en String, poniendo
    /// el mensaje "has ganado" si la cuenta de cubos es 12
    /// (si se ha colisionado con todos los cubos)
    /// </remarks>
    /// </summary>
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}