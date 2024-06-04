using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField]
    private Text SaludTexto;
    private int Salud;

    void SaludDisplay(int cantidad)
    {
        Salud = Salud + cantidad;
        SaludTexto.text = "Monedas: " + Salud;
    }

    private void OnEnable()
    {
        PlayerHealth.CambioSaludEvent += CoinTextDisplay;
    }

    private void OnDisable()
    {
        Coin.CoinEvent -= CoinTextDisplay;
    }
}
