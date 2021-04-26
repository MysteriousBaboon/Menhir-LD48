using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Script_Rock : MonoBehaviour
{
	public AudioSource m_MyAudioSource;
	public int pierre_id;


	public GameObject MenhirMap;

	Script_MenhirMap script;

    // Start is called before the first frame update
    void Start()
    {
    	m_MyAudioSource = GetComponent<AudioSource>();
		script = MenhirMap.GetComponent<Script_MenhirMap>();
    }

    void OnMouseDown()
    {
    	script.caillou_got_click(pierre_id);
	}

    public void PlaySong()
    {
		m_MyAudioSource.Play(0);
    }
}
