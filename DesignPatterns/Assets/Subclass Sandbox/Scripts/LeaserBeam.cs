using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LeaserBeam : MonoBehaviour
{
    //This is the sandbox method in which the children shoot Leaser Beam
    public abstract void Activate(GameObject leaserBeam, bool on);
    public abstract void Deactivate(GameObject leaserBeam, bool off);

    //Different Leaser Beams

    protected void PlaySound(string sound)
    {
        Debug.Log($"Playing sound {sound}");
    }

    protected void ShootLeaser(GameObject leaserBeam, bool activeState)
    {
        leaserBeam.SetActive(activeState);
    }
}
