using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Generation : MonoBehaviour
{                                 
    public static int rows = 21; // Number of row for Cell Generation
    public static int cols = 21; // Number of Columns
    public Object[] cells_Type; // Array of all type of cells
    // Store all object in an 2D array
    public  GameObject[,] cells = new GameObject[rows, cols];

    void GenerateMap()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                cells[row, col] = (GameObject)Instantiate(cells_Type[0]); // Randomizing the type of tile that will be generetad next
            }
        }

    }


    void Start()
    {
        GenerateMap();
    }

    void Update()
    {
         if (Input.GetKeyDown("space"))
        {
            
        Color color = cells[0,0].GetComponent<SpriteRenderer>().color;
        color.a = 1f;
        cells[0,0].GetComponent<SpriteRenderer>().color = color;

        }

    }
}
