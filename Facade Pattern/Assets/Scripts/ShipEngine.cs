using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipEngine : MonoBehaviour
{
    public float burnRate = 0.1f;
    public float fuelAmount = 100.0f;
    public float tempRate = 0.5f;
    public float minTemp = 0.0f;
    public float maxTemp = 100.0f;
    public float currentTemp = 0.0f;
    public float turboDuration = 2.0f;
    public float coolRate = 0.5f;
    public bool isEngineOn;
    private FuelPump fuelPump;
    private TurboCharger turboCharger;
    private CoolingSystem coolingSystem;



    private void Awake()
    {
        fuelPump = gameObject.AddComponent<FuelPump>();
        turboCharger = gameObject.AddComponent<TurboCharger>();
        coolingSystem = gameObject.AddComponent<CoolingSystem>();
    }

    private void Start()
    {
        fuelPump.engine = this;
        turboCharger.engine = this;
        coolingSystem.engine = this;
    }


    public void TurnOn()
    {
        isEngineOn = true;
        StartCoroutine(fuelPump.burnFuel);
        StartCoroutine(coolingSystem.coolEngine);
    }
    public void TurnOff()
    {
        isEngineOn = false;
        StopCoroutine(fuelPump.burnFuel);
        StopCoroutine(coolingSystem.coolEngine);
    }
    public void ToggleTurbo()
    {
        if (isEngineOn)
        {
            turboCharger.ToggleTurbo(coolingSystem);
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(100, 0, 500, 20), "Engine Running: " + isEngineOn);
    }
}
