using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurboCharger : MonoBehaviour
{

    public ShipEngine engine;

    private bool isTurboOn;
    private CoolingSystem coolingSystem;

    public void ToggleTurbo(CoolingSystem aCoolingSystem)
    {
        this.coolingSystem = aCoolingSystem;
        if (!isTurboOn)
        {
            StartCoroutine(TurboCharge());
        }
    }

    IEnumerator TurboCharge()
    {
        isTurboOn = true;
        this.coolingSystem.PauseCooling();

        yield return new WaitForSeconds(engine.turboDuration);

        this.isTurboOn = false;
        this.coolingSystem.PauseCooling();
    }

    private void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(100, 60, 500, 20), "Turbo Activated: " + this.isTurboOn);
    }
}
