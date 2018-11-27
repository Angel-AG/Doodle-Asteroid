using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeSurvive : MonoBehaviour {

    public float survive;
    public TextMeshProUGUI surviveUI;
	
	// Update is called once per frame
	void Update () {
        if (survive > 0)
        {
            surviveUI.text = "Survive: " + survive.ToString() + "s";
        }
        survive -= Time.deltaTime;
    }
}
