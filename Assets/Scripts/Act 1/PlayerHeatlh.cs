using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeatlh : MonoBehaviour
{
    public int salud;
    public static event Action<int> CambioSaludEvent;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CambiarSalud()
    {
        if (Input.GetKeyDown("E"))
        {
            CambioSaludEvent?.Invoke(1);
        }
    }
}
