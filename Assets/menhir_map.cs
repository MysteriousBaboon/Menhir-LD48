using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menhir_map : MonoBehaviour
{
	public GameObject c1;
	public GameObject c2;
	public GameObject c3;

	public GameObject menhir;

	caillou1 s1;
	caillou1 s2;
	caillou1 s3;

	ChangeSpriteFromSheet m;

	int[] good_combinaison = {1, 3, 1, 2, 3, 3};
	int good_combinaison_count = 0;
	bool victory = false;

    // Start is called before the first frame update
    void Start()
    {
    	s1 = c1.GetComponent<caillou1>();
		s2 = c2.GetComponent<caillou1>();
		s3 = c3.GetComponent<caillou1>();
		m = menhir.GetComponent<ChangeSpriteFromSheet>();
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
    		update_menhir();
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

    void click_caillou(caillou1 s, int id)
    {
    	//if (!s.m_MyAudioSource.isPlaying)

    	//s.StartAnim();

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
