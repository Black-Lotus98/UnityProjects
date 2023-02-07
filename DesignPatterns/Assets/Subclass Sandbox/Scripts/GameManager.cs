using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GreenLeaser greenLeaser;
    private GreenLeaser redLeaser;
    private int leaserIndex = 0;
    public List<GameObject> leaserBeams;
    bool activeState = true;
    void Start()
    {
        greenLeaser = new GreenLeaser();
        redLeaser = new GreenLeaser();
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            greenLeaser.Activate(leaserBeams[leaserIndex], activeState);
        }
        else
        {
            greenLeaser.Deactivate(leaserBeams[leaserIndex], !activeState);

        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            leaserIndex = 0;
            greenLeaser.Deactivate(leaserBeams[1], !activeState);

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            leaserIndex = 1;
            greenLeaser.Deactivate(leaserBeams[0], !activeState);

        }

    }
}
