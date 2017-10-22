using UnityEngine;
using System.Collections;

public class PersistObject : MonoBehaviour {


	private static PersistObject instance = null;
	public static PersistObject Instance {
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
	// any other methods you need
}