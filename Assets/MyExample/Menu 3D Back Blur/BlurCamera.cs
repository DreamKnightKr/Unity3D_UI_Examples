using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlurCamera : MonoBehaviour {
	public RawImage targetImg;

	// Use this for initialization
	void Start () {
		RenderTexture rendT = new RenderTexture(Screen.width/3, Screen.height/3, 16, RenderTextureFormat.ARGB32);
		targetImg.texture = rendT;

		Camera cam = GetComponent<Camera> ();
		cam.targetTexture = rendT;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
