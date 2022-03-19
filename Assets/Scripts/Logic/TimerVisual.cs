using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerVisual : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private Text text;



    void Update()
    {
        text.text = timer.CurrentTime + "";
    }
}
