using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class result : MonoBehaviour
{
    public GameObject TopPanel;
    public GameObject ResPanel;

    public void OnSearch(){
        if (ResPanel.activeSelf == false && TopPanel.activeSelf == true)
        {
            TopPanel.SetActive(false);
            ResPanel.SetActive(true);
        }
        else
        {
            ResPanel.SetActive(false);
            ResPanel.SetActive(true);
        }
    }
}
