using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {
    //button events need to be public
	public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
