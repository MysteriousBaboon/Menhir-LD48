using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteFromSheet : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite sprite3;
	public int actif = 0;

	public void ChangeSprite(int i)
    {
    	if (i == 0)
    	{
    		spriteRenderer.sprite = sprite1;
    	}
    	else if (i == 1)
    	{
    		spriteRenderer.sprite = sprite2;
    	}
    	else if (i == 2)
    	{
    		spriteRenderer.sprite = sprite3;
    	}
    	else
    	{
    		Destroy(gameObject);
    	}
        actif = i;
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = sprite1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
