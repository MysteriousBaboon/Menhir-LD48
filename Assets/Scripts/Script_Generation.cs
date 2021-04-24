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
    public float[] tiles_Probability;
    public int x,y = 0;

    private int DeterminateCellType()
    {
        float probability_Max = tiles_Probability[0] + tiles_Probability[1] + tiles_Probability[2];
        float value = Random.Range(0f, probability_Max);

        if (value < tiles_Probability[0])
        {
            return 0;
        }

        else
        {
            if ((tiles_Probability[0] + tiles_Probability[1]) > value)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }

    void GenerateMap()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {

                cells[row, col] = (GameObject)Instantiate(cells_Type[DeterminateCellType()]); // Randomizing the type of tile that will be generetad next
                
            }
        }

    }

    void Move(int X, int Y)
    {
            Color color = cells[x,y].GetComponent<SpriteRenderer>().color;
            color.a = 0f;
            cells[x,y].GetComponent<SpriteRenderer>().color = color;

            Color color2 = cells[x+X,y+Y].GetComponent<SpriteRenderer>().color;
            color2.a = 1f;
            x += X;
            y += Y;
            cells[x,y].GetComponent<SpriteRenderer>().color = color2;
    }

    void Start()
    {
        GenerateMap();
        Color color = cells[0,0].GetComponent<SpriteRenderer>().color;
        color.a = 1f;
        cells[0,0].GetComponent<SpriteRenderer>().color = color;
    }

    void Update()
    {
         if (Input.GetKeyDown("space"))
        {
            Move(1,1);
        }

    }





      
}
    

