using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_coin : MonoBehaviour
{
    public int index;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnMouseDown()
    {
        GameObject controller = GameObject.FindGameObjectWithTag("controller");
        controller.GetComponent<go_coffre>().passIndex(index);
    }
}

