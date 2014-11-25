#pragma strict

function OnTriggerEnter(col : Collider){
	Application.LoadLevel(Application.levelCount + 1);
}