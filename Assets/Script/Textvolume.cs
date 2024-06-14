using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Textvolume : MonoBehaviour
{
    Text volume;
    public Slider slide;
    void Start()
    {
        volume = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        volume.text = $"VOLUME : {(slide.value*100).ToString("00")}%";
    }
}
