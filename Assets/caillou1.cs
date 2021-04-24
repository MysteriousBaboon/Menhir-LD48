using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caillou1 : MonoBehaviour
{
	public AudioSource m_MyAudioSource;
	private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
    	m_MyAudioSource = GetComponent<AudioSource>();
    	anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartAnim()
    {
    	anim.Play("pierre");
    }

    public void PlaySong()
    {
		m_MyAudioSource.Play(0);
    }
}
