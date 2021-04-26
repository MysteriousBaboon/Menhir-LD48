using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMusic : MonoBehaviour
{
	public AudioSource m_MyAudioSource;

	void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
    	m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start_music()
    {
		m_MyAudioSource.Play(0);
    }
}
