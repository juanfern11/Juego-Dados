using TMPro;
using UnityEngine;

public class PuntosManager : MonoBehaviour
{
    public static PuntosManager instancia;
    public TMP_Text textPuntos;
    private int puntuacion;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        puntuacion = 0;
        ActualizarUI();
    }

    public void AgregarPuntos(int cantidad)
    {
        puntuacion += cantidad;
        ActualizarUI();
    }

    public void QuitarPuntos(int cantidad)
    {
        puntuacion -= cantidad;
        if (puntuacion < 0) puntuacion = 0;
        ActualizarUI();
    }

    public void SetPuntos(int cantidad)
    {
        puntuacion = cantidad;
        if (puntuacion < 0) puntuacion = 0;
        ActualizarUI();
    }

    public int GetPuntos()
    {
        return puntuacion;
    }

    private void ActualizarUI()
    {
        if (textPuntos != null)
        {
            textPuntos.text = $"Puntuación: {puntuacion}";
        }
    }
}
