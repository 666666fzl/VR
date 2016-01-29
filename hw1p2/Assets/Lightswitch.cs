using UnityEngine;
using System.Collections;

public class Lightswitch : MonoBehaviour {
    public Light myLight;
	// Use this for initialization
	void Start () {
        myLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyUp(KeyCode.Tab)) {
            myLight.enabled = !myLight.enabled;
        }
	}
}

