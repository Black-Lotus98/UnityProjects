using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneType : MonoBehaviour
{
    public ZoneApplication app { get { return GameObject.FindObjectOfType<ZoneApplication>(); } }
}

public class ZoneApplication : MonoBehaviour
{
    public ZoneModel model;
    public ZoneController controller;
    public ZoneView view;

}
