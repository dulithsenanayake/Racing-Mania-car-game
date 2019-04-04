using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour {

    public static int CarType;
    public GameObject ModeWindow;

    public void BlueCar()
    {
        CarType = 1;
        ModeWindow.SetActive(true);
    }
    public void RedCar()
    {
        CarType = 2;
        ModeWindow.SetActive(true);
    }
    public void GreenCar()
    {
        CarType = 3;
        ModeWindow.SetActive(true);
    }
}
