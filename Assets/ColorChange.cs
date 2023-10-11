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
		yield return new WaitForSeconds(7.25f * tscale); //7.25
		r.enabled = true;
		
		m.color = Color.red;
		subs.text = "Rojo\nRojo";
		yield return new WaitForSeconds(5.0f * tscale); //12.25
		
		m.color = Color.blue;
		subs.text = "Azul\nAzul";
		yield return new WaitForSeconds(4.75f * tscale); //17
		
		m.color = Color.green;
		subs.text = "Verde\nVerde";
		yield return new WaitForSeconds(4.25f * tscale); //21.25
		
		m.color = Color.white;
		subs.text = "Blanco\nBlanco";
		yield return new WaitForSeconds(4.25f * tscale); //25.5
		
		m.color = Color.black;
		subs.text = "Negro\nNegro";
		yield return new WaitForSeconds(4.5f * tscale); //30
		
		m.color = Color.yellow;
		subs.text = "Amarillo\nAmarillo";
		yield return new WaitForSeconds(5.0f * tscale); //35
		
		m.color = orange;
		subs.text = "Anaranjado\nAnaranjado";
		yield return new WaitForSeconds(7.0f * tscale); //42
		
		m.color = brown;
		subs.text = "Color café\nColor café";
		yield return new WaitForSeconds(5.25f * tscale); //47.25
		
		m.color = Color.grey;
		subs.text = "Gris\nGris";
		yield return new WaitForSeconds(5.0f * tscale); //52.25
		
		m.color = pink;
		subs.text = "Rosado\nRosado";
		yield return new WaitForSeconds(4.75f * tscale); //57
		
		r.enabled = false;
		subs.text = "";
	}
	
	//For the "What color is this?" video/audio.
	IEnumerator colorScriptQuestion(){
		//Start
		m.color = pink;
		subs.text = "¿Qué color es?";
		//"What color is this?"
		yield return new WaitForSeconds(5.0f * tscale); //5
		subs.text = "Es rosado.";
		yield return new WaitForSeconds(2.5f * tscale); //7.5
		
		m.color = Color.yellow;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(2.5f * tscale); //10
		subs.text = "Es amarillo.";
		yield return new WaitForSeconds(3.0f * tscale); //13
		
		m.color = brown;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(3.0f * tscale); //16
		subs.text = "Es color café.";
		yield return new WaitForSeconds(3.0f * tscale); //19
		
		m.color = orange;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(3.0f * tscale); //22
		subs.text = "Es aranjado.";
		yield return new WaitForSeconds(3.0f * tscale); //25
		
		m.color = Color.blue;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(2.75f * tscale); //27.75
		subs.text = "Es azul.";
		yield return new WaitForSeconds(2.25f * tscale); //30
		
		r.enabled = false;
		subs.text = "";
	}
}
