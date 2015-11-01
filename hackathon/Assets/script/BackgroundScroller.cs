using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {

	public float speed = 0;
	public BackgroundScroller current;
	public Texture[] textures;
	private int selected = 0;

	float pos = 0;

	// Use this for initialization
	void Start () {
		current = this;



	}

	public void Go (){
		pos += speed;
		if (pos > 1.0f)
			pos -= 1.0f;
		
		var renderer = GetComponent<Renderer> ();
		renderer.material.mainTextureOffset = new Vector2 (pos, 0);


	}

	public void next(){

		selected++;
		selected = selected % textures.Length;
		var myRenderer = gameObject.GetComponent<Renderer> ();
		myRenderer.material.mainTexture = textures [selected];

	}
	
	// Update is called once per frame
	void Update () {
		//print ("go");

	
	}
}
