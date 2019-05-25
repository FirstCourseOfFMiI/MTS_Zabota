using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core_UI_Logick : MonoBehaviour {

    public GameObject Menu;
    public GameObject Home;
    public GameObject Track;
    public GameObject Nyny;
    public GameObject Buy;

    public void F_Home()
    {
        Home.SetActive(true);
        Track.SetActive(false);
        Buy.SetActive(false);
        Nyny.SetActive(false);
        Menu.SetActive(false);
    }

    public void F_Track()
    {
        Home.SetActive(false);
        Track.SetActive(true);
        Buy.SetActive(false);
        Nyny.SetActive(false);
        Menu.SetActive(false);

    }

    public void F_Buy()
    {
        Home.SetActive(false);
        Track.SetActive(false);
        Buy.SetActive(true);
        Nyny.SetActive(false);
        Menu.SetActive(false);

    }

    public void F_Nyny()
    {
        Home.SetActive(false);
        Track.SetActive(false);
        Buy.SetActive(false);
        Nyny.SetActive(true);
        Menu.SetActive(false);
    }

    public void F_Menu()
    {
        Home.SetActive(false);
        Track.SetActive(false);
        Buy.SetActive(false);
        Nyny.SetActive(false);
        Menu.SetActive(true);
    }

}
