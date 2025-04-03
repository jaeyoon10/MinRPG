using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITest : MonoBehaviour
{

    public Image img;
    public Button btn;
    public Slider slider;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        img.color = Color.white;
        img.color = new Color(0.5f, 0.5f, 0.5f);

        btn.interactable = true;
        btn.interactable = false;
        
        slider.interactable = true;
        slider.interactable = false;
        slider.minValue = 0;
        slider.maxValue = 100;
        slider.value = 50;

        text.text = "æ»≥Á«œººø‰";
        text.fontStyle = FontStyle.Bold;
        text.fontStyle = FontStyle.Italic;
        text.fontSize = 30;
        text.color = Color.white;

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
