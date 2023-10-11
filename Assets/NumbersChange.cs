using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumbersChange : MonoBehaviour
{
	public float tscale = 1.0f;
	private GameObject subtitles;
	private TextMeshPro subs = null;
	
    void Start()
    {
		subtitles = GameObject.Find("Subtitles");
		subs = subtitles.GetComponent<TextMeshPro>();
		if (subs){
			StartCoroutine(numberScriptRepeat());
		}
		else {
			Debug.Log("Failed to start numbers change; subtitles not found");
		}
    }

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
}
