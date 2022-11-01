using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class UpdateScore : MonoBehaviour
{
    public TMP_Text text;
    public Movement Movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + (Movement.score).ToString();
    }
}
