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
		yield return new WaitForSeconds(7.0f * tscale); //Needs to be timed
		
		subs.text = "Diez\n10";
		yield return new WaitForSeconds(5.0f * tscale); //
		
		subs.text = "Once\n11";
		yield return new WaitForSeconds(5.0f * tscale); //
		
		subs.text = "Doce\n12";
		yield return new WaitForSeconds(4.0f * tscale); //
		
		subs.text = "Trece\n13";
		yield return new WaitForSeconds(4.0f * tscale); //
		
		subs.text = "Catorce\n14";
		yield return new WaitForSeconds(4.0f * tscale); //
		
		subs.text = "Quince\n15";
		yield return new WaitForSeconds(5.0f * tscale); //
		
		subs.text = "Dieciséis\n16";
		yield return new WaitForSeconds(6.0f * tscale); //
		
		subs.text = "Diecisiete\n17";
		yield return new WaitForSeconds(6.0f * tscale); //
		
		subs.text = "Dieciocho\n18";
		yield return new WaitForSeconds(5.0f * tscale); //
		
		subs.text = "Diecinueve\n19";
		yield return new WaitForSeconds(6.0f * tscale); //
		
		subs.text = "Veinte\n20";
		yield return new WaitForSeconds(6.0f * tscale); //
		//Note: There's actually eleven words. Not sure if that matters -C
		
		subs.text = "";
	}
	
	//For the "What number is this?" video/audio.
	IEnumerator numberScriptQuestion(){
		//Start
		subs.text = "¿Qué número es?\n11";
		//"What shape is this?"
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		subs.text = "Es once.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		subs.text = "¿Qué número es?\n15";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es quince.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		subs.text = "¿Qué número es?\n13";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es trece.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		subs.text = "¿Qué número es?\n19";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es diecinueve.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		subs.text = "¿Qué número es?\n16";
		yield return new WaitForSeconds(1.0f * tscale); //
		subs.text = "Es dieciséis.";
		yield return new WaitForSeconds(1.0f * tscale); //Needs to be timed
		
		subs.text = "";
	}
}
