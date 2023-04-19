using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    private List<IBikeElement> bikeElements = new List<IBikeElement>();

    private void Start()
    {
        bikeElements.Add(gameObject.AddComponent<BikeShield>());
        bikeElements.Add(gameObject.AddComponent<BikeEngin>());
        bikeElements.Add(gameObject.AddComponent<BikeWeapon>());
    }


    public void Accept(IVisitor aVisitor)
    {
        foreach (IBikeElement bikeElement in bikeElements)
        {
            bikeElement.Accept(aVisitor);
        }
    }



}
