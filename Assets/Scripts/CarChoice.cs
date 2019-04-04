using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {

    public GameObject BlueCar;
    public GameObject RedCar;
    public GameObject GreenCar;
    public int CarImport;

    void Start () {
        CarImport = GlobalCar.CarType;
        if(CarImport == 1)
        {
            BlueCar.SetActive(true);
        }
        if (CarImport == 2)
        {
            RedCar.SetActive(true);
        }
        if(CarImport == 3)
        {
            GreenCar.SetActive(true);
        }
    }
	
}
