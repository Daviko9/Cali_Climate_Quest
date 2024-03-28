using UnityEngine;
using UnityEngine.UI;

public class Generador : MonoBehaviour
{
    public GameObject[] prefabsBasura; // Array de prefabs de basura
    public float intervaloGeneracion = 1f; // Intervalo de generaci�n en segundos
    public float margenX = 5f; // Margen horizontal en el que se generar�n las basuras
    public float alturaGeneracion = 10f; // Altura en la que se generar�n las basuras
    public float tiempoLimite = 60f; // Tiempo l�mite en segundos (1 minuto)
    private float tiempoTranscurrido = 0f;
    private int puntos = 0;
    public Text textoTiempo; // Referencia al componente de texto para el tiempo
    public Text textoPuntos; // Referencia al componente de texto para los puntos
    public GameObject canvasGameOver;
    public GameObject canvasGameOver2;

    private bool juegoTerminado = false;

    private void Start()
    {
        // Comenzar a generar basura
        InvokeRepeating("GenerarBasura", 0f, intervaloGeneracion);
    }

    private void Update()
    {
        if (!juegoTerminado)
        {
            // Actualizar el tiempo transcurrido
            tiempoTranscurrido += Time.deltaTime;

            // Verificar si se alcanz� el tiempo l�mite
            if (tiempoTranscurrido >= tiempoLimite)
            {
                juegoTerminado = true;
                Debug.Log("Tiempo agotado. Puntos finales: " + puntos);
                CancelInvoke(); // Detener la repetici�n de la generaci�n de basura
                                // Aqu� puedes agregar l�gica adicional para manejar el final del juego

                // Activar el Canvas de Game Over
                canvasGameOver.SetActive(true);
                canvasGameOver2.SetActive(false);

            }

            // Actualizar el texto del tiempo
            textoTiempo.text = "Tiempo: " + Mathf.Round(tiempoLimite - tiempoTranscurrido).ToString() + "s";

            // Actualizar el texto de los puntos
            textoPuntos.text = "Puntos: " + puntos.ToString();
        }
    }

    private void GenerarBasura()
    {
        if (!juegoTerminado)
        {
            // Seleccionar aleatoriamente un prefab de basura del array
            GameObject prefabSeleccionado = prefabsBasura[Random.Range(0, prefabsBasura.Length)];

            // Calcular una posici�n aleatoria dentro del margen horizontal
            Vector3 posicionGeneracion = new Vector3(Random.Range(-margenX, margenX), alturaGeneracion, 0f);

            // Instanciar un objeto de basura en la posici�n calculada
            GameObject nuevaBasura = Instantiate(prefabSeleccionado, posicionGeneracion, Quaternion.identity);

            // Asignar velocidad y l�mite inferior al objeto de basura
            Organico organicoComponent = nuevaBasura.GetComponent<Organico>();
            Plastico plasticoComponent = nuevaBasura.GetComponent<Plastico>();
            Vidrio vidrioComponent = nuevaBasura.GetComponent<Vidrio>();

            if (organicoComponent != null)
            {
                organicoComponent.velocidadCaida = Random.Range(1f, 5f); // Velocidad aleatoria
                organicoComponent.limiteInferior = -10f; // Ajusta seg�n el l�mite inferior de la pantalla
            }
            else if (plasticoComponent != null)
            {
                plasticoComponent.velocidadCaida = Random.Range(1f, 5f); // Velocidad aleatoria
                plasticoComponent.limiteInferior = -10f; // Ajusta seg�n el l�mite inferior de la pantalla
            }
            else if (vidrioComponent != null)
            {
                vidrioComponent.velocidadCaida = Random.Range(1f, 5f); // Velocidad aleatoria
                vidrioComponent.limiteInferior = -10f; // Ajusta seg�n el l�mite inferior de la pantalla
            }
        }
    }

    public void SumarPunto()
    {
        puntos++;
        Debug.Log("�Basura depositada correctamente! Puntos: " + puntos);
    }

    public void RestarPunto()
    {
        puntos--;
        if (puntos < 0)
        {
            puntos = 0;
        }
        Debug.Log("�La basura se destruy�! Puntos: " + puntos);
        // Actualizar el texto de los puntos
        textoPuntos.text = "Puntos: " + puntos.ToString();
    }
}
