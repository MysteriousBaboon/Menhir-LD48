using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_labyrinth : MonoBehaviour
{
    public  GameObject[] cells;
    private int i = 0;

    // Start is called before the first frame update
    void Move()
    {
            Color color = cells[i].GetComponent<SpriteRenderer>().color;
            color.a = 0f;
            cells[i].GetComponent<SpriteRenderer>().color = color;

            i++;
            
            Color color2 = cells[i].GetComponent<SpriteRenderer>().color;
            color2.a = 1f;
            cells[i].GetComponent<SpriteRenderer>().color = color2;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Move();
        }
    }
}
