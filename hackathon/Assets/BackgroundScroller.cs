using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {

	public float speed = 0;
	public BackgroundScroller current;

	float pos = 0;

	// Use this for initialization
	void Start () {
		current = this;
	}

	public void Go (){


	}
	
	// Update is called once per frame
	void Update () {
		print ("go");
		pos += speed;
		if (pos > 1.0f)
			pos -= 1.0f;
		
		var renderer = GetComponent<Renderer> ();
		renderer.material.mainTextureOffset = new Vector2 (pos, 0);

	
	}
}
