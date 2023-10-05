using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorChange : MonoBehaviour
{
	public float tscale = 1.0f;
    private Material m;
	private Renderer r;
	private GameObject subtitles;
	private TextMeshPro subs = null;
	Color pink = new Color(1.0f, 0.75f, 0.8f, 1.0f);
	Color brown = new Color(0.24f, 0.17f, 0.12f, 1.0f);
	Color orange = new Color(1.0f, 0.65f, 0.0f, 1.0f);
	
    void Start()
    {
		r = GetComponent<Renderer>();
		m = r.material;
		subtitles = GameObject.Find("Subtitles");
		subs = subtitles.GetComponent<TextMeshPro>();
		if (m&&subs){
			StartCoroutine(colorScriptRepeat());
		}
		else {
			Debug.Log("Failed to start color change; material and/or subtitles not found");
		}
    }

	//For the "Repeat after me" video/audio.
    IEnumerator colorScriptRepeat(){
		//Start Video/Audio
		r.enabled = false;
		subs.text = "¡Hola! Vamos aprendernos los colores. Repeta.";
		//"Hello! We are going to learn the colors. Repeat after me."
		yield return new WaitForSeconds(7.0f * tscale); //7, times could be more accurate.
		r.enabled = true;
		
		m.color = Color.red;
		subs.text = "Rojo\nRojo";
		yield return new WaitForSeconds(5.0f * tscale); //12
		
		m.color = Color.blue;
		subs.text = "Azul\nAzul";
		yield return new WaitForSeconds(5.0f * tscale); //17
		
		m.color = Color.green;
		subs.text = "Verde\nVerde";
		yield return new WaitForSeconds(4.0f * tscale); //21
		
		m.color = Color.white;
		subs.text = "Blanco\nBlanco";
		yield return new WaitForSeconds(4.0f * tscale); //25
		
		m.color = Color.black;
		subs.text = "Negro\nNegro";
		yield return new WaitForSeconds(4.0f * tscale); //29
		
		m.color = Color.yellow;
		subs.text = "Amarillo\nAmarillo";
		yield return new WaitForSeconds(5.0f * tscale); //34
		
		m.color = orange;
		subs.text = "Anaranjado\nAnaranjado";
		yield return new WaitForSeconds(6.0f * tscale); //40
		
		m.color = brown;
		subs.text = "Color café\nColor café";
		yield return new WaitForSeconds(6.0f * tscale); //46
		
		m.color = Color.grey;
		subs.text = "Gris\nGris";
		yield return new WaitForSeconds(5.0f * tscale); //51
		
		m.color = pink;
		subs.text = "Rosado\nRosado";
		yield return new WaitForSeconds(6.0f * tscale); //57
		
		r.enabled = false;
		subs.text = "";
	}
	
	//For the "What color is this?" video/audio.
	IEnumerator colorScriptQuestion(){
		//Start
		m.color = pink;
		subs.text = "¿Qué color es?";
		//"What color is this?"
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		subs.text = "Es rosado.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		m.color = Color.yellow;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es amarillo.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		m.color = brown;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es color café.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		m.color = orange;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es aranjado.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		m.color = Color.blue;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es azul.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		r.enabled = false;
		subs.text = "";
	}
}
