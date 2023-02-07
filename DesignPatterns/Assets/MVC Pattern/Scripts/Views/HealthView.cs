using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthView : ZoneType
{
    void OnTriggerStay() { app.controller.OnHealthZoneEnter(); }

}
