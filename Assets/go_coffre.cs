using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class go_coffre : MonoBehaviour
{

    public GameObject[] list;
    // Start is called before the first frame update
    private int last_index = 5;
    public int count_clik = 0;
    public int var_p0 = 0;
    public int var_p1 = 0;
    public float red, green, blue;
    int step = 0;
    void Start()
    {


    }

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
                GameObject[] Gos = GameObject.FindGameObjectsWithTag("coffre");

                foreach (GameObject objet in Gos)
                {
                    Color col = objet.GetComponent<SpriteRenderer>().color;
                    if ( col != new Color(0.5f, 0.2f, 0.9f)) break;
                }
                print("on se jean marie");
            }
            print(step);
        }
    }



}

 /*

// UP
        if (Math.Abs(diff) <= 4 & last_index %5 == 0)
        {
            for (int i = current_index; last_index <= i; i--)
            {
                Color Color_piece = list[i].GetComponent<SpriteRenderer>().color;
                Color_piece = new Color(0.5f, 0.2f, 0.9f);
                list[i].GetComponent<SpriteRenderer>().color = Color_piece;
            }
            change = true;
        }
// DOWN
        if (Math.Abs(diff2) <= 4 & (last_index - 4) %  5 == 0)
        {
            for (int i = last_index; current_index <= i; i--)
            {
                Color Color_piece = list[i].GetComponent<SpriteRenderer>().color;
                Color_piece = new Color(0.5f, 0.2f, 0.9f);
                list[i].GetComponent<SpriteRenderer>().color = Color_piece;
            }
            change = true;
        }


// Droite
        if (mod == 0 | mod == 4)
        {
            for (int i = last_index; i <= current_index; i += 5)
            {
                Color Color_piece = list[i].GetComponent<SpriteRenderer>().color;
                Color_piece = new Color(0.5f, 0.2f, 0.9f);
                list[i].GetComponent<SpriteRenderer>().color = Color_piece;
            }
            change = true;
        }
// Gauche
        if (mod2 == 0)
        {
            print("aljt");
            print(last_index);
            print(current_index);
         
            for (int i = last_index; i >= current_index; i -= 5)
            {
                print("test");


                Color Color_piece = list[i].GetComponent<SpriteRenderer>().color;
                Color_piece = new Color(0.5f, 0.2f, 0.9f);
                list[i].GetComponent<SpriteRenderer>().color = Color_piece;
            }
            change = true;

        }
        if (diff2 % 6 == 0 & current_index / 5 != last_index / 5 & last_index < current_index)
        {
            print("diagonale droite");
            start_index = last_index;
            limit_index = current_index;
            if (last_index % 5 < current_index % 5)
            {
                increase_index = 6;
            }
            else
            {
                increase_index = 4;
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

    else if diff2 % 4 == 0 & current_index
        if (current_index < last_index)
        {
            start_index = current_index;
            limit_index = last_index;
            if (current_index % 5 < last_index % 5)
            {
                increase_index = 6;
            }
            else
            {
                increase_index = 4;
            }
        }
        else
        {
            start_index = last_index;
            limit_index = current_index;
            if (last_index % 5 < current_index % 5)
            {
                increase_index = 6;
            }
            else
            {
                increase_index = 4;
            }
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

        else if (Math.Abs(diff) == 6 | Math.Abs(diff) == 4)
        {
            Color Color_piece = list[current_index].GetComponent<SpriteRenderer>().color;
            Color_piece = new Color(0.5f, 0.2f, 0.9f);
            list[current_index].GetComponent<SpriteRenderer>().color = Color_piece;

        

    }
}




            switch (current_index)
            {
            case 0:
                Color Color_piece0 = list[0].GetComponent<SpriteRenderer>().color;
                Color_piece0 = new Color(red, green, blue); ;
                list[0].GetComponent<SpriteRenderer>().color = Color_piece0;
                count_clik = count_clik + 1;
                var_p0 = 1;
                break;
            case 1:
                if (var_p0 == 1)
                {
                    Color Color_piece1 = list[1].GetComponent<SpriteRenderer>().color;
                    Color_piece1 = new Color(red, green, blue); ;
                    list[1].GetComponent<SpriteRenderer>().color = Color_piece1;
                    count_clik = count_clik + 1;
                    var_p1 = 1;
                }
                break;

            }
        */