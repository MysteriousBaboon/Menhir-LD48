using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Generation : MonoBehaviour
{                                 
    [SerializeField]
    private static int rows = 21; // Number of row for Tiles Generation
    [SerializeField]
    private static int cols = 21; // Number of Columns
    public Object[] cells_Type; // Array of all type of cells
    public  GameObject[,] cells = new GameObject[rows, cols];
    // Start is called before the first frame update


    void Start()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                cells[row, col] = (GameObject)Instantiate(cells_Type[0]); // Randomizing the type of tile that will be generetad next
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
