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
		yield return new WaitForSeconds(5.25f * tscale); //5.25
		r.enabled = true;
		
		changeShape("rectangle");
		subs.text = "Rectángulo\nRectángulo";
		yield return new WaitForSeconds(5.75f * tscale); //11
		
		changeShape("circle");
		subs.text = "Círculo\nCírculo";
		yield return new WaitForSeconds(5.5f * tscale); //16.5
		
		changeShape("triangle");
		subs.text = "Triángulo\nTriángulo";
		yield return new WaitForSeconds(5.5f * tscale); //22
		
		changeShape("square");
		subs.text = "Cuadrado\nCuadrado";
		yield return new WaitForSeconds(5.0f * tscale); //27
		
		changeShape("trapezoid");
		subs.text = "Trapecio\nTrapecio";
		yield return new WaitForSeconds(5.75f * tscale); //32.75
		
		changeShape("oval");
		subs.text = "Óvalo\nÓvalo";
		yield return new WaitForSeconds(5.0f * tscale); //37.75
		
		changeShape("rhombus");
		subs.text = "Rombo\nRombo";
		yield return new WaitForSeconds(5.25f * tscale); //43
		
		changeShape("heart");
		subs.text = "Corazón\nCorazón";
		yield return new WaitForSeconds(5.0f * tscale); //48
		
		changeShape("ring");
		subs.text = "Anillo\nAnillo";
		yield return new WaitForSeconds(5.5f * tscale); //53.5
		
		changeShape("star");
		subs.text = "Estrella\nEstrella";
		yield return new WaitForSeconds(5.5f * tscale); //59
		
		r.enabled = false;
		subs.text = "";
	}
	
	//For the "What shape is this?" video/audio.
	IEnumerator shapeScriptQuestion(){
		//Start
		changeShape("circle");
		subs.text = "¿Qué forma es?";
		//"What shape is this?"
		yield return new WaitForSeconds(4.0f * tscale); //4
		subs.text = "Es un circulo.";
		yield return new WaitForSeconds(3.5f * tscale); //7.5
		
		changeShape("rectangle");
		subs.text = "¿Qué forma es?";
		yield return new WaitForSeconds(3.25f * tscale); //10.75
		subs.text = "Es un rectángulo.";
		yield return new WaitForSeconds(4.0f * tscale); //14.75
		
		changeShape("star");
		subs.text = "¿Qué forma es?";
		yield return new WaitForSeconds(2.75f * tscale); //17.5
		subs.text = "Es una estrella.";
		yield return new WaitForSeconds(3.25f * tscale); //20.75
		
		changeShape("rhombus");
		subs.text = "¿Qué forma es?";
		yield return new WaitForSeconds(2.25f * tscale); //23
		subs.text = "Es un rombo.";
		yield return new WaitForSeconds(3.0f * tscale); //26
		
		changeShape("heart");
		subs.text = "¿Qué forma es?";
		yield return new WaitForSeconds(2.0f * tscale); //28
		subs.text = "Es yb corazón.";
		yield return new WaitForSeconds(3.0f * tscale); //31
		
		r.enabled = false;
		subs.text = "";
	}
}
