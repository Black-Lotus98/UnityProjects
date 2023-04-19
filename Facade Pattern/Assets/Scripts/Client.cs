using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    private ShipEngine shipEngine;



    void Start()
    {
        shipEngine = gameObject.AddComponent<ShipEngine>();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Turn On"))
        {
            shipEngine.TurnOn();
        }
        if (GUILayout.Button("Turn Off"))
        {
            shipEngine.TurnOff();
        }
        if (GUILayout.Button("Toggle Turbo"))
        {
            shipEngine.ToggleTurbo();
        }
    }


}
