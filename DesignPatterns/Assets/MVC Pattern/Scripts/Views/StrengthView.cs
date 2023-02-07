using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthView : ZoneType
{
    void OnTriggerStay() { app.controller.OnStrengthZoneEnter(); }
  
}
