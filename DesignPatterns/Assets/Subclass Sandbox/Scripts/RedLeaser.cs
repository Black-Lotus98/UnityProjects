using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLeaser : LeaserBeam
{
    public override void Activate(GameObject leaserBeam, bool on)
    {
        PlaySound("Launch sound");
        ShootLeaser(leaserBeam, on);
    }
    public override void Deactivate(GameObject leaserBeam, bool off)
    {
        PlaySound("Launch sound");
        ShootLeaser(leaserBeam, off);
    }
}
