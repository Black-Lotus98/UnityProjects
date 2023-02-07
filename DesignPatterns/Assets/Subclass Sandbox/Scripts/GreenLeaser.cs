using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLeaser : LeaserBeam
{
    public override void Activate(GameObject leaserBeam, bool on, AudioClip leaserSound )
    {
        PlaySound(leaserSound);
        ShootLeaser(leaserBeam, on);
    }
    public override void Deactivate(GameObject leaserBeam ,bool off,AudioClip leaserSound)
    {
        StopSound(leaserSound);
        ShootLeaser(leaserBeam, off);
    }
}
