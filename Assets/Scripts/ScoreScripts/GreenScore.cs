using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenScore : MonoBehaviour {

    void OnTriggerEnter()
    {
        ModeScore.CurrentScore += 150;
        gameObject.SetActive(false);
    }
}
