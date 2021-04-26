using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Script_Chest : MonoBehaviour
{

    public GameObject[] list;
    // Start is called before the first frame update
    private int last_index = 5;
    public int count_clik = 0;
    public int var_p0 = 0;
    public int var_p1 = 0;
    public float red, green, blue;
    int step = 0;

    // Update is called once per frame
    void Update()
    {
        Color Color_piece = list[5].GetComponent<SpriteRenderer>().color;
        Color_piece = new Color(red, green, blue);
        list[5].GetComponent<SpriteRenderer>().color = Color_piece;
    }

    public void passIndex(int current_index)
    {
        //int diff = current_index - last_index;
        //int diff2 = Math.Abs(last_index - current_index);

        //int mod = diff % 5;
        //int mod2 = diff2 % 5;
        int start_index;
        int limit_index;
        int increase_index;
        bool change = false;

        if (current_index == last_index)
        {
            return;
        }
        int col_current = current_index / 5;
        int col_last = last_index / 5;

        int row_current = current_index % 5;
        int row_last = last_index % 5;


        // ligne
        if (row_current == row_last & col_current != col_last)
        {
            start_index = last_index;
            limit_index = current_index;
            if (current_index < last_index)
            {
                start_index = current_index;
                limit_index = last_index;
            }
            while (start_index <= limit_index)
            {
                Color Color_piece = list[start_index].GetComponent<SpriteRenderer>().color;
                Color_piece = new Color(0.5f, 0.2f, 0.9f);
                list[start_index].GetComponent<SpriteRenderer>().color = Color_piece;

                start_index += 5;
            }
            change = true;
        }

        // colonne
        else if (row_current != row_last & col_current == col_last)
        {
            start_index = last_index;
            limit_index = current_index;
            if (current_index < last_index)
            {
                start_index = current_index;
                limit_index = last_index;
            }
            while (start_index <= limit_index)
            {
                Color Color_piece = list[start_index].GetComponent<SpriteRenderer>().color;
                Color_piece = new Color(0.5f, 0.2f, 0.9f);
                list[start_index].GetComponent<SpriteRenderer>().color = Color_piece;

                start_index += 1;
            }
            change = true;

        }

        //diagonale
        else if (Math.Abs(row_current - row_last) == Math.Abs(col_current - col_last))
        {
            if (current_index < last_index & row_current > row_last)
            {
                start_index = current_index;
                limit_index = last_index;
                increase_index = 4;
            }
            else if (last_index < current_index & row_last > row_current)
            {
                start_index = last_index;
                limit_index = current_index;
                increase_index = 4;
            }
            else if (current_index < last_index & row_current < row_last)
            {
                start_index = current_index;
                limit_index = last_index;
                increase_index = 6;
            }
            else
            {
                start_index = last_index;
                limit_index = current_index;
                increase_index = 6;
            }


            while (start_index <= limit_index)
            {
                Color Color_piece = list[start_index].GetComponent<SpriteRenderer>().color;
                Color_piece = new Color(0.5f, 0.2f, 0.9f);
                list[start_index].GetComponent<SpriteRenderer>().color = Color_piece;

                start_index += increase_index;
            }
            change = true;
        }

        if (change)
        {
            last_index = current_index;
            step += 1;
            if (step == 4)
            {
                if(isWin())
                {
                    print("Il a win");
                }
                
                else
                {
                    print("il a loose");
                }
            }
        }
    }

bool isWin()
{
    GameObject[] Gos = GameObject.FindGameObjectsWithTag("chest");

    foreach (GameObject objet in Gos)
    {
        Color col = objet.GetComponent<SpriteRenderer>().color;
        if ( col != new Color(0.5f, 0.2f, 0.9f)) return false;
    }
    return true;
}


}
