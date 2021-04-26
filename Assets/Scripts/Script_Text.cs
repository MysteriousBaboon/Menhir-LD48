using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Script_Text : MonoBehaviour
{
    public string text;
    private string actual_text = "";
    private float actual_time = 0f;
    public float time_between_letters;
    public Text text_object;
    private int index = 0;
    public string scene;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        actual_time += Time.deltaTime;
        if(actual_text == text)
        {
            if(Input.anyKey)
            {
                SceneManager.LoadScene(scene);
            }
        }
        
        else
        {
            if(actual_time > time_between_letters)
            {
                actual_text += text[index];
                index++;
                text_object.text = actual_text.Replace("$", "\n");
                actual_time = 0f;

            }
        }
    }

}
