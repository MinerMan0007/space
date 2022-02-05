using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0", "hello, walcom to my iland","1");
        Speech.AddDialogue("1", "help us - there are monster in are iland", "2");
        Speech.AddDialogue("2", "finde powerup, collect all coins and go to next iland", "3");
        Speech.AddDialogue("3", "be carefull");
        Speech.AddDialogue("4", "i see you have founde powerup, now go get to the next iland");

    }

    // Triggered when the player comes in range of the NPC
    public override void OnTriggerNPC( Collider other ){
        if (Abilities.doubleJumpEnabled)
        {
            Speech.SetDialogue("4");
        }
        else
        {
            Speech.SetDialogue("0");
        }
        
	}
}