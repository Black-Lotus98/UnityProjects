using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaView : ZoneType
{
    void OnTriggerStay() { app.controller.OnManaZoneEnter(); }
    
}
