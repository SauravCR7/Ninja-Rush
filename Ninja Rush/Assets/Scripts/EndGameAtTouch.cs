using UnityEngine;
using System.Collections;

public class EndGameAtTouch : MonoBehaviour {

	public bool endWithWin;

	void OnTriggerExit2D(Collider2D target) {
		if (target.gameObject.tag == "Player") {

			if (endWithWin == true) {
				PersistentManager.dataStore.endGameWithWin ();
			} else {
				PersistentManager.dataStore.endGameWithLoss ();
			}

		}
	}


}
