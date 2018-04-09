using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InstructionsController : MonoBehaviour {

	public Text stepText;
	private int currentStep;

	// Use this for initialization
	void Start () {
		currentStep = 0;
		CurrentInstructionUpdate ();

	}

	public void NextStep() {
		currentStep++;
		CurrentInstructionUpdate ();
	}

	public void PreviousStep() {
		currentStep--;
		CurrentInstructionUpdate ();

	}

	private void CurrentInstructionUpdate(){
		stepText.text = "Step:" + currentStep;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
