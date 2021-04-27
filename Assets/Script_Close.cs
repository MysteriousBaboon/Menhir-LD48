using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Close : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    } 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))Application.Quit();

    }
}
