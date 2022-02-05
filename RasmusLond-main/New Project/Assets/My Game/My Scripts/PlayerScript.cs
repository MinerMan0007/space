using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public int coin;

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start() {
        
	}

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided) {

		// Check for collision with coins
		if (collided.gameObject.tag == "Coin") {
            coin++;
        HUD.Message("you got coin heheheheh");
            HUD.UpdateCoinCount(coin);
			Destroy(collided.gameObject);
		}

        if (collided.gameObject.name == "Powerup 1")
        {
            HUD.Message("you have dubele jump");
            Abilities.doubleJumpEnabled=true;
            Destroy(collided.gameObject);
        }

        if (collided.gameObject.name == "Powerup 2")
        {
            HUD.Message("you have spin attack");
            Abilities.spinAttackEnabled = true;
            Destroy(collided.gameObject);
        }
    }
}