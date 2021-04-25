using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caillou1 : MonoBehaviour
{
	public AudioSource m_MyAudioSource;
	private Animation anim;
	public int pierre_id;


	public GameObject menhir_map;

	menhir_map script;

    // Start is called before the first frame update
    void Start()
    {
    	m_MyAudioSource = GetComponent<AudioSource>();
    	anim = gameObject.GetComponent<Animation>();
		script = menhir_map.GetComponent<menhir_map>();

    }

    void OnMouseDown()
    {
    	script.caillou_got_click(pierre_id);
	}

    public void StartAnim()
    {
    	//anim.Play("pierre");
    }

    public void PlaySong()
    {
		m_MyAudioSource.Play(0);
    }
}
