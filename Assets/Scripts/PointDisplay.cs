using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointDisplay : MonoBehaviour
{
    private TMP_Text point;
    private GameManager gm;

    private void OnEnable()
    {
        if (point == null) point = GetComponent<TMP_Text>();

        gm = GameManager.Instance; 
        gm.OnPointChange += UpdateDisplay;
    }

    private void OnDisable()
    {
        gm.OnPointChange -= UpdateDisplay;
    }

    private void UpdateDisplay(int value)
    {
        point.text = value.ToString();
    }
}
