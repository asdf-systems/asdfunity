using UnityEngine;
using System.Collections;

public class TestUIControllerBehaviour : InteractionBehaviour {

	private SampleUIController controller;
	void AwakeOverride(){
		base.AwakeOverride();
		controller = new SampleUIController();
		
	}
	
	public override void Click(MouseEventArgs mouse){
		//controller.Trigger = true;	
	}
}
