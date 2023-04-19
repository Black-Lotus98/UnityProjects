using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CliendVisitor : MonoBehaviour
{
    public PowerUp enginePowerUp;
    public PowerUp shieldPowerUp;
    public PowerUp weaponPowerUp;

    private BikeController bikeController;
    void Start()
    {
        bikeController = gameObject.AddComponent<BikeController>();
    }


    private void OnGUI()
    {
        if (GUILayout.Button("Power Up Shield"))
        {
            bikeController.Accept(shieldPowerUp);
        }
        if (GUILayout.Button("Power Up Engine"))
        {
            bikeController.Accept(shieldPowerUp);
        }
        if (GUILayout.Button("Power Up Weapon"))
        {
            bikeController.Accept(weaponPowerUp);
        }
    }
}