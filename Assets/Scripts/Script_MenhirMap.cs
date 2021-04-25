using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_MenhirMap : MonoBehaviour
{
	public GameObject c1;
	public GameObject c2;
	public GameObject c3;

	public GameObject menhir;

	Script_Rock s1;
	Script_Rock s2;
	Script_Rock s3;

	Script_Menhir m;

	int[] good_combinaison = {1, 3, 1, 2, 3, 3};
	int good_combinaison_count = 0;
	bool victory = false;

    // Start is called before the first frame update
    void Start()
    {
    	s1 = c1.GetComponent<Script_Rock>();
		s2 = c2.GetComponent<Script_Rock>();
		s3 = c3.GetComponent<Script_Rock>();
		m = menhir.GetComponent<Script_Menhir>();
    }

    // Update is called once per frame
    void Update()
    {
    	if (victory)
    	{
    		print("WP");
    	}
    	else if (!victory)
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

    void update_menhir()
    {
    	print(good_combinaison_count);
    	int wanted = good_combinaison_count / 2;
    	if (good_combinaison_count == good_combinaison.Length)
    	{
    		wanted = 3;
    	}
    	if (m.actif != wanted)
		{
			m.ChangeSprite(wanted);
		}
    }

    void click_caillou(Script_Rock s, int id)
    {
    	//if (!s.m_MyAudioSource.isPlaying)

    	s.StartAnim();

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
        update_menhir();
    }

    public void	caillou_got_click(int id)
    {
    	if (id == 1)
    	{
	    	click_caillou(s1, 1);
    	}
    	else if (id == 2)
    	{
	    	click_caillou(s2, 2);
    	}
    	else if (id == 3)
    	{
	    	click_caillou(s3, 3);
    	}
    }
}
