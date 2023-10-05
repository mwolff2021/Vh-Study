using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShapeChange : MonoBehaviour
{
	public float tscale = 1.0f;
	private Renderer r;
	private GameObject subtitles;
	private TextMeshPro subs = null;
	
    void Start()
    {
		r = GetComponent<Renderer>();
		subtitles = GameObject.Find("Subtitles");
		subs = subtitles.GetComponent<TextMeshPro>();
		if (r&&subs){
			StartCoroutine(shapeScriptRepeat());
		}
		else {
			Debug.Log("Failed to start shape change; renderer and/or subtitles not found");
		}
    }
	
	void changeShape(string shapename){
		r.material.mainTexture = Resources.Load(shapename, typeof(Texture)) as Texture;
	}

	//For the "Repeat after me" video/audio.
    IEnumerator shapeScriptRepeat(){
		//Start Video/Audio
		r.enabled = false;
		subs.text = "Vamos aprendernos las formas. Repeta.";
		//"We are going to learn the shapes. Repeat after me."
		yield return new WaitForSeconds(7.0f * tscale); //Needs to be timed
		r.enabled = true;
		
		changeShape("rectangle");
		subs.text = "Rectángulo\nRectángulo";
		yield return new WaitForSeconds(5.0f * tscale); //
		
		changeShape("circle");
		subs.text = "Círculo\nCírculo";
		yield return new WaitForSeconds(5.0f * tscale); //
		
		changeShape("triangle");
		subs.text = "Triángulo\nTriángulo";
		yield return new WaitForSeconds(4.0f * tscale); //
		
		changeShape("square");
		subs.text = "Cuadrado\nCuadrado";
		yield return new WaitForSeconds(4.0f * tscale); //
		
		changeShape("trapezoid");
		subs.text = "Trapecio\nTrapecio";
		yield return new WaitForSeconds(4.0f * tscale); //
		
		changeShape("oval");
		subs.text = "Óvalo\nÓvalo";
		yield return new WaitForSeconds(5.0f * tscale); //
		
		changeShape("rhombus");
		subs.text = "Rombo\nRombo";
		yield return new WaitForSeconds(6.0f * tscale); //
		
		changeShape("heart");
		subs.text = "Corazón\nCorazón";
		yield return new WaitForSeconds(6.0f * tscale); //
		
		changeShape("ring");
		subs.text = "Anillo\nAnillo";
		yield return new WaitForSeconds(5.0f * tscale); //
		
		changeShape("star");
		subs.text = "Estrella\nEstrella";
		yield return new WaitForSeconds(6.0f * tscale); //
		
		r.enabled = false;
		subs.text = "";
	}
	
	//For the "What shape is this?" video/audio.
	IEnumerator shapeScriptQuestion(){
		//Start
		changeShape("circle");
		subs.text = "¿Qué forma es?";
		//"What shape is this?"
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		subs.text = "Es un circulo.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		changeShape("rectangle");
		subs.text = "¿Qué forma es?";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es un rectángulo.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		changeShape("star");
		subs.text = "¿Qué forma es?";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es una estrella.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		changeShape("rhombus");
		subs.text = "¿Qué forma es?";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es un rombo.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		changeShape("heart");
		subs.text = "¿Qué forma es?";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es yb corazón.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		r.enabled = false;
		subs.text = "";
	}
}
