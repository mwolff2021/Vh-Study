using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllerScript : MonoBehaviour
{
	public float tscale = 1.0f;
	public string id = "abc";
	private GameObject subtitles, shape_block, color_block;
	private TextMeshPro subs = null;
	private Renderer shape_rend, color_rend;
	private Material color_mat;
	
	Color pink = new Color(1.0f, 0.75f, 0.8f, 1.0f);
	Color brown = new Color(0.24f, 0.17f, 0.12f, 1.0f);
	Color orange = new Color(1.0f, 0.65f, 0.0f, 1.0f);
	
    void Start(){
		subtitles = GameObject.Find("Subtitles");
		subs = subtitles.GetComponent<TextMeshPro>();
		
		color_block = GameObject.Find("Color Block");
		color_rend = color_block.GetComponent<Renderer>();
		color_mat = color_rend.material;
		color_rend.enabled = false;
		
		shape_block = GameObject.Find("Shape Block");
		shape_rend = shape_block.GetComponent<Renderer>();
		shape_rend.enabled = false;
		
		//Grab Jen Avatar
		
		//Grab Personalized Avatar
		
		//Grab audio
		
		if (id.Length != 3){
			id = "abc";
			Debug.Log("ID length invalid!");
		}
		string fail_id = id;
		foreach (char i in id){
			switch(i){
				case 'a':
				case 'b':
				case 'c':
					break;
				default:
					fail_id = "abc";
					Debug.Log(i + " is an invalid character!");
					break;
			}
		}
		id = fail_id;
		Debug.Log("ID: " + id);
    }
	
	void OnGUI(){
		GUI.Box(new Rect(10,10,280,90), "Test");
		
		if(GUI.Button(new Rect(20,40,80,20), "Shape Repeat")){
            StartCoroutine(shapeScriptRepeat());
        }
		
        if(GUI.Button(new Rect(20,70,80,20), "Shape Question")){
            StartCoroutine(shapeScriptQuestion());
        }
		
		if(GUI.Button(new Rect(110,40,80,20), "Color Repeat")){
            StartCoroutine(colorScriptRepeat());
        }
		
		if(GUI.Button(new Rect(110,70,80,20), "Color Question")){
            StartCoroutine(colorScriptQuestion());
        }
		
		if(GUI.Button(new Rect(200,40,80,20), "Number Repeat")){
            StartCoroutine(numberScriptRepeat());
        }
		
		if(GUI.Button(new Rect(200,70,80,20), "Number Question")){
            StartCoroutine(numberScriptQuestion());
        }
	}
	
	//Functions
	//
	void setScene(int routine){
		//WIP
		char i = id[routine];
		switch(i){
			case 'a':
				//Apply audio
				break;
			case 'b':
				//Apply Jen's avatar
				break;
			case 'c':
				//Apply Self-Similar avatar
				break;
		}
	}
	
	//Coroutines
	//
	//Colors
	//For the "Repeat after me" video/audio.
    IEnumerator colorScriptRepeat(){
		//Start Video/Audio
		color_rend.enabled = false;
		subs.text = "¡Hola! Vamos aprendernos los colores. Repeta.";
		//"Hello! We are going to learn the colors. Repeat after me."
		yield return new WaitForSeconds(7.25f * tscale); //7.25
		color_rend.enabled = true;
		
		color_mat.color = Color.red;
		subs.text = "Rojo\nRojo";
		yield return new WaitForSeconds(5.0f * tscale); //12.25
		
		color_mat.color = Color.blue;
		subs.text = "Azul\nAzul";
		yield return new WaitForSeconds(4.75f * tscale); //17
		
		color_mat.color = Color.green;
		subs.text = "Verde\nVerde";
		yield return new WaitForSeconds(4.25f * tscale); //21.25
		
		color_mat.color = Color.white;
		subs.text = "Blanco\nBlanco";
		yield return new WaitForSeconds(4.25f * tscale); //25.5
		
		color_mat.color = Color.black;
		subs.text = "Negro\nNegro";
		yield return new WaitForSeconds(4.5f * tscale); //30
		
		color_mat.color = Color.yellow;
		subs.text = "Amarillo\nAmarillo";
		yield return new WaitForSeconds(5.0f * tscale); //35
		
		color_mat.color = orange;
		subs.text = "Anaranjado\nAnaranjado";
		yield return new WaitForSeconds(7.0f * tscale); //42
		
		color_mat.color = brown;
		subs.text = "Color café\nColor café";
		yield return new WaitForSeconds(5.25f * tscale); //47.25
		
		color_mat.color = Color.grey;
		subs.text = "Gris\nGris";
		yield return new WaitForSeconds(5.0f * tscale); //52.25
		
		color_mat.color = pink;
		subs.text = "Rosado\nRosado";
		yield return new WaitForSeconds(4.75f * tscale); //57
		
		color_rend.enabled = false;
		subs.text = "";
	}
	
	//For the "What color is this?" video/audio.
	IEnumerator colorScriptQuestion(){
		//Start
		color_rend.enabled = true;
		color_mat.color = pink;
		subs.text = "¿Qué color es?";
		//"What color is this?"
		yield return new WaitForSeconds(5.0f * tscale); //5
		subs.text = "Es rosado.";
		yield return new WaitForSeconds(2.5f * tscale); //7.5
		
		color_mat.color = Color.yellow;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(2.5f * tscale); //10
		subs.text = "Es amarillo.";
		yield return new WaitForSeconds(3.0f * tscale); //13
		
		color_mat.color = brown;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(3.0f * tscale); //16
		subs.text = "Es color café.";
		yield return new WaitForSeconds(3.0f * tscale); //19
		
		color_mat.color = orange;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(3.0f * tscale); //22
		subs.text = "Es aranjado.";
		yield return new WaitForSeconds(3.0f * tscale); //25
		
		color_mat.color = Color.blue;
		subs.text = "¿Qué color es?";
		yield return new WaitForSeconds(2.75f * tscale); //27.75
		subs.text = "Es azul.";
		yield return new WaitForSeconds(2.25f * tscale); //30
		
		color_rend.enabled = false;
		subs.text = "";
	}
	
	//Numbers
	//For the "Repeat after me" video/audio.
    IEnumerator numberScriptRepeat(){
		//Start Video/Audio
		subs.text = "¡Hola! Vamo apprendellos números. Repeta";
		//"Hello! We are going to learn the numbers. Repeat after me."
		yield return new WaitForSeconds(8.75f * tscale); //8.75
		
		subs.text = "Diez\n10";
		yield return new WaitForSeconds(4.75f * tscale); //13.5
		
		subs.text = "Once\n11";
		yield return new WaitForSeconds(4.25f * tscale); //17.75
		
		subs.text = "Doce\n12";
		yield return new WaitForSeconds(4.5f * tscale); //22.25
		
		subs.text = "Trece\n13";
		yield return new WaitForSeconds(3.5f * tscale); //25.5
		
		subs.text = "Catorce\n14";
		yield return new WaitForSeconds(6.5f * tscale); //32
		
		subs.text = "Quince\n15";
		yield return new WaitForSeconds(4.25f * tscale); //36.25
		
		subs.text = "Dieciséis\n16";
		yield return new WaitForSeconds(6.0f * tscale); //42.25
		
		subs.text = "Diecisiete\n17";
		yield return new WaitForSeconds(6.5f * tscale); //48.75
		
		subs.text = "Dieciocho\n18";
		yield return new WaitForSeconds(5.5f * tscale); //54.25
		
		subs.text = "Diecinueve\n19";
		yield return new WaitForSeconds(4.75f * tscale); //59
		
		subs.text = "Veinte\n20";
		yield return new WaitForSeconds(3.0f * tscale); //1:02
		//Note: There's actually eleven words. Not sure if that matters -C
		
		subs.text = "";
	}
	
	//For the "What number is this?" video/audio.
	IEnumerator numberScriptQuestion(){
		//Start
		subs.text = "¿Qué número es?\n11";
		//"What shape is this?"
		yield return new WaitForSeconds(7.5f * tscale); //7.5
		subs.text = "Es once.";
		yield return new WaitForSeconds(3.0f * tscale); //10.5
		
		subs.text = "¿Qué número es?\n15";
		yield return new WaitForSeconds(2.5f * tscale); //13
		subs.text = "Es quince.";
		yield return new WaitForSeconds(3.75f * tscale); //16.75
		
		subs.text = "¿Qué número es?\n13";
		yield return new WaitForSeconds(3.0f * tscale); //19.75
		subs.text = "Es trece.";
		yield return new WaitForSeconds(3.75f * tscale); //23.5
		
		subs.text = "¿Qué número es?\n19";
		yield return new WaitForSeconds(2.25f * tscale); //26
		subs.text = "Es diecinueve.";
		yield return new WaitForSeconds(3.25f * tscale); //29.25
		
		subs.text = "¿Qué número es?\n16";
		yield return new WaitForSeconds(3.25f * tscale); //32.5
		subs.text = "Es dieciséis.";
		yield return new WaitForSeconds(2.5f * tscale); //35
		
		subs.text = "";
	}
	
	//Shapes
	void changeShape(string shapename){
		shape_rend.material.mainTexture = Resources.Load(shapename, typeof(Texture)) as Texture;
	}
	
	//For the "Repeat after me" video/audio.
    IEnumerator shapeScriptRepeat(){
		//Start Video/Audio
		shape_rend.enabled = false;
		subs.text = "Vamos aprendernos las formas. Repeta.";
		//"We are going to learn the shapes. Repeat after me."
		yield return new WaitForSeconds(5.25f * tscale); //5.25
		shape_rend.enabled = true;
		
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
		
		shape_rend.enabled = false;
		subs.text = "";
	}
	
	//For the "What shape is this?" video/audio.
	IEnumerator shapeScriptQuestion(){
		//Start
		shape_rend.enabled = true;
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
		subs.text = "Es un corazón.";
		yield return new WaitForSeconds(3.0f * tscale); //31
		
		shape_rend.enabled = false;
		subs.text = "";
	}
}
