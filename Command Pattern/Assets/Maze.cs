using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    public int height;
    public int width;
    int[,] arrayGrid;

    int x, z;
    public GameObject cube;
    void Start()
    {
        arrayGrid = new int[height, width];
        InstantiateCubes();
        DrawMap();

    }

    void InstantiateCubes()
    {

        for (z = 0; z < height; z++)
        {
            for (x = 0; x < width; x++)
            {
                arrayGrid[z, x] = 1;
            }
        }

    }

    void DrawMap()
    {

        for (z = 0; z < height; z++)
        {
            for (x = 0; x < width; x++)
            {
                if (arrayGrid[z, x] == 1)
                {
                    Vector3 pos = new Vector3((x - width/2), 1, (z - height/2));
                    Instantiate(cube, pos, Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
