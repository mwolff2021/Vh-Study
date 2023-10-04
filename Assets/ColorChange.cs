using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
	public float tscale = 1.0f;
    private Material m;
	private Renderer r;
	//private GameObject subtitles;
	//private TextMeshPro subs;
	Color pink = new Color(1.0f, 0.75f, 0.8f, 1.0f);
	Color brown = new Color(0.24f, 0.17f, 0.12f, 1.0f);
	Color orange = new Color(1.0f, 0.65f, 0.0f, 1.0f);
	
    void Start()
    {
		r = GetComponent<Renderer>();
		m = r.material;
		//Still having issues with this, will need to look at more documentation. -c
		//subtitles = GameObject.Find("Subtitles");
		//subs = subtitles.GetComponent<TextMeshPro>();
		if (m){
			StartCoroutine(colorScriptRepeat());
		}
		else {
			Debug.Log("Failed to start color change; material not found");
		}
    }

	//For the "Repeat after me" video/audio.
    IEnumerator colorScriptRepeat(){
		//Start Video/Audio
		r.enabled = false;
		//subs.text = "Test";
		yield return new WaitForSeconds(7.0f * tscale); //7, times could be more accurate.
		r.enabled = true;
		
		m.color = Color.red;
		yield return new WaitForSeconds(5.0f * tscale); //12
		
		m.color = Color.blue;
		yield return new WaitForSeconds(5.0f * tscale); //17
		
		m.color = Color.green;
		yield return new WaitForSeconds(4.0f * tscale); //21
		
		m.color = Color.white;
		yield return new WaitForSeconds(4.0f * tscale); //25
		
		m.color = Color.black;
		yield return new WaitForSeconds(4.0f * tscale); //29
		
		m.color = Color.yellow;
		yield return new WaitForSeconds(5.0f * tscale); //34
		
		m.color = orange;
		yield return new WaitForSeconds(6.0f * tscale); //40
		
		m.color = brown;
		yield return new WaitForSeconds(6.0f * tscale); //46
		
		m.color = Color.grey;
		yield return new WaitForSeconds(5.0f * tscale); //51
		
		m.color = pink;
		yield return new WaitForSeconds(6.0f * tscale); //57
		
		r.enabled = false;
	}
	
	//For the "What color is this?" video/audio.
	IEnumerator colorScriptQuestion(){
		//Start
		m.color = pink;
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		m.color = Color.yellow;
		yield return new WaitForSeconds(1.0f * tscale); //
		
		m.color = brown;
		yield return new WaitForSeconds(1.0f * tscale); //
		
		m.color = orange;
		yield return new WaitForSeconds(1.0f * tscale); //
		
		m.color = Color.blue;
		yield return new WaitForSeconds(1.0f * tscale); //
		
		r.enabled = false;
	}
}
