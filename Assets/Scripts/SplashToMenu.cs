using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour {

	
	void Start () {
        StartCoroutine(ToMenu());
	}
	IEnumerator ToMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);

    }
}
