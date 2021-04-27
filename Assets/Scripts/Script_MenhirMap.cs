using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Script_MenhirMap : MonoBehaviour
{

	public GameObject c1;
	public GameObject c2;
	public GameObject c3;

    public GameObject cr1;
    public GameObject cr2;
    public GameObject cr3;

    public GameObject music;

	public GameObject menhir;

    public string levelName;

	Script_Rock s1;
	Script_Rock s2;
	Script_Rock s3;

    StoneMusic s_music;

	Script_Menhir m;

	int[] good_combinaison = {1, 3, 1, 2, 3, 3};
	int good_combinaison_count = 0;
	bool victory = false;
    bool end_music_started = false;

    // Start is called before the first frame update
    void Start()
    {
        s_music = music.GetComponent<StoneMusic>();
        GameObject obj = GameObject.FindWithTag("music_main");
        if (obj != null)
        {
            Destroy(obj);
        }
    	s1 = c1.GetComponent<Script_Rock>();
		s2 = c2.GetComponent<Script_Rock>();
		s3 = c3.GetComponent<Script_Rock>();
		m = menhir.GetComponent<Script_Menhir>();
        cr1.SetActive(false);
        cr2.SetActive(false);
        cr3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (end_music_started & Input.anyKey)
        {
            SceneManager.LoadScene(levelName);
        }
    	else if (victory & !s3.m_MyAudioSource.isPlaying & !end_music_started)
    	{
            end_music_started = true;
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
    	s.PlaySong();

		if (good_combinaison[good_combinaison_count] == id)
        {
        	good_combinaison_count += 1;
            cr1.SetActive(false);
            cr2.SetActive(false);
            cr3.SetActive(false);
        }
        else
        {
        	good_combinaison_count = 0;
            cr1.SetActive(true);
            cr2.SetActive(true);
            cr3.SetActive(true);
        }
        if (good_combinaison_count == good_combinaison.Length)
        {
            s_music.start_music();

        	victory = true;
        }
        update_menhir();
    }

    public void	caillou_got_click(int id)
    {
        if (!victory)
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
}
