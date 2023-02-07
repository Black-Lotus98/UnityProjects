using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageView : ZoneType
{
    void OnTriggerStay() { app.controller.OnDamageZoneEnter(); }

}
