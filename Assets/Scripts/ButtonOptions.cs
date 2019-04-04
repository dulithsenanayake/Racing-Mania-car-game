using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(6);
    }
    public void CarSelect()
    {
        SceneManager.LoadScene(3);
    }
    public void ModeSelect()
    {
        SceneManager.LoadScene(4);
    }
    public void TrackSelect()
    {
        SceneManager.LoadScene(5);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(2);
    }

    
    //below here are track selection buttons
    public void Track01()
    {
        SceneManager.LoadScene(6);
    }
    public void Track02()
    {
        SceneManager.LoadScene(7);
    }
}
