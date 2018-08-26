using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrettingsBehaviour : MonoBehaviour
{

	public InputField Number1Input;
	public InputField Number2Input;
	public Text OutputText;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SayHello()
	{
		Debug.Log("Add numbers");
		var number1 = Int32.Parse(Number1Input.text);
		var number2 = Int32.Parse(Number2Input.text);

		
		Debug.Log("The addition is " + (number1 + number2) );

		OutputText.text = (number1 + number2).ToString();

	}
}
