using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Logick : MonoBehaviour {

    public GameObject StartPanel;
    public GameObject _Registr;
    public GameObject _Registr_Dopl;
    public GameObject _Vhod;

	public void Registeracia()
    {
        StartPanel.SetActive(false);
        _Registr.SetActive(true);
    }

    public void Vhod()
    {
        StartPanel.SetActive(false);
        _Vhod.SetActive(true);
    }

    public void Back()
    {
        StartPanel.SetActive(true);
        _Registr.SetActive(false);
        _Vhod.SetActive(false);
    }

    public void Registeracia_Dopl()
    {
        _Registr_Dopl.SetActive(true);
        _Registr.SetActive(false);
    }

    public void Back_D()
    {
        _Registr_Dopl.SetActive(false);
        _Registr.SetActive(true);
    }

}
