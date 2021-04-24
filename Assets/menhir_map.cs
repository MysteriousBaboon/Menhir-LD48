using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menhir_map : MonoBehaviour
{
	public GameObject c1;
	public GameObject c2;
	public GameObject c3;

	caillou1 s1;
	caillou1 s2;
	caillou1 s3;


	int[] good_combinaison = {1, 2, 3};
	int good_combinaison_count = 0;
	bool victory = false;


    // Start is called before the first frame update
    void Start()
    {
    	s1 = c1.GetComponent<caillou1>();
		s2 = c2.GetComponent<caillou1>();
		s3 = c3.GetComponent<caillou1>();
    }

    // Update is called once per frame
    void Update()
    {
    	if (victory)
    	{
    		print("WP");
    	}
    	if (!victory)
    	{
    		if (Input.GetKeyDown("left"))
    		{
    			click_caillou(s1, 1);
    		}
    		else if (Input.GetKeyDown("up"))
    		{
    			click_caillou(s2, 2);
    		}
    		else if (Input.GetKeyDown("right"))
    		{
    			click_caillou(s3, 3);
    		}
    	}
    }

    /*
    void click_caillou(int id)
    {
    	if (!s1.m_MyAudioSource.isPlaying)
        {

        }
    	if (id == 1)
    	{
    		s1.PlaySong();
    	}
    	else if (id == 2)
    	{
    		s2.PlaySong();
    	}
    	else if (id == 3)
    	{
    		s3.PlaySong();
    	}
    	
    }
    */
    void click_caillou(caillou1 s, int id)
    {
    	if (!s1.m_MyAudioSource.isPlaying)
    	{
    		s.PlaySong();
    		if (good_combinaison[good_combinaison_count] == id)
	        {
	        	good_combinaison_count += 1;
	        }
	        else
	        {
	        	good_combinaison_count = 0;
	        }
	        if (good_combinaison_count == good_combinaison.Length)
	        {
	        	victory = true;
	        }
    	}
    }
}
