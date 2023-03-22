using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeapon : MonoBehaviour
{

    public WeaponConfig weaponConfig;
    // here is where you would add in multiple attachments, in this case we have only 2
    public WeaponAttachment mainAttachment;
    public WeaponAttachment secondAttachment;

    private bool isFiring;
    private IWeapon weapon;
    private bool isDecorated;


    void Start()
    {
        this.weapon = new Weapon(weaponConfig);
    }

    void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(5, 50, 200, 100), "Firing Rate: " + weapon.Rate);
        GUI.Label(new Rect(5, 70, 200, 100), "Range: " + weapon.Range);
        GUI.Label(new Rect(5, 90, 200, 100), "Strength: " + weapon.Strength);
        GUI.Label(new Rect(5, 110, 200, 100), "Cooldown: " + weapon.Cooldown);
        GUI.Label(new Rect(5, 130, 200, 100), "Weapon Firing: " + isFiring);
        if (mainAttachment && isDecorated)
        {
            GUI.Label(new Rect(5, 170, 200, 100), "Main Attachment: " + mainAttachment.attachmentName);
        }
        if (secondAttachment && isDecorated)
        {
            GUI.Label(new Rect(5, 200, 200, 100), "Secondary Attachment: " + secondAttachment.attachmentName);
        }
    }
    public void ToggleFire()
    {
        isFiring = !isFiring;
        if (isFiring)
        {
            StartCoroutine(FireWeapon());
        }
    }
    IEnumerator FireWeapon()
    {
        float firingRate = 10 / weapon.Rate;
        while (isFiring)
        {
            yield return new WaitForSeconds(firingRate);
            Debug.Log($"Fire {firingRate}");
        }
    }

    public void Reset()
    {
        weapon = new Weapon(weaponConfig);
        isFiring = false;
    }

    public void Decorate()
    {
        isFiring = false;

        if (mainAttachment && !secondAttachment)
        {
            weapon = new WeaponDecorator(weapon, mainAttachment);
        }
        if (mainAttachment && secondAttachment)
        {
            weapon = new WeaponDecorator(new WeaponDecorator(weapon, mainAttachment), secondAttachment);
        }

        isDecorated = !isDecorated;
    }

    void Update()
    {

    }
}
