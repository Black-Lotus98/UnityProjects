using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientDecorator : MonoBehaviour
{
    private ShipWeapon shipWeapon;
    private bool isWeaponDecorated;
    // Start is called before the first frame update
    void Start()
    {
        shipWeapon = (ShipWeapon)FindObjectOfType(typeof(ShipWeapon));
    }
    void OnGUI()
    {
        if (!isWeaponDecorated == true)
        {
            if (GUILayout.Button("Decorated Weapon")) 
            {
                shipWeapon.Decorate();
                isWeaponDecorated = !isWeaponDecorated;
            }
        }

        if (isWeaponDecorated == false)
        {
            if (GUILayout.Button("Reset Weapon")) 
            {
                shipWeapon.Reset();
                isWeaponDecorated = !isWeaponDecorated;
            }
        }

        if (GUILayout.Button("Toggle Fire")) 
        {
            shipWeapon.ToggleFire();
        }

    }
}
