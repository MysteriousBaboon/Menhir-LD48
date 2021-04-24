using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caillou1 : MonoBehaviour
{
	public AudioSource m_MyAudioSource;

    // Start is called before the first frame update
    void Start()
    {
    	m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySong()
    {
		m_MyAudioSource.Play(0);
    }
}
