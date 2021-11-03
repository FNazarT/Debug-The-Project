using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{    
    [SerializeField] private ParticleSystem sparksParticles;

    private readonly List<string> textToDisplay = new List<string>();
    private TextMesh text;
    private float timeToNextText = 0f;
    private int currentText = 0;
    
    void Start()
    {
        textToDisplay.Add("Congratulation");
        textToDisplay.Add("All Errors Fixed");

        text = GetComponent<TextMesh>();
        text.text = textToDisplay[0];
        
        sparksParticles.Play();
    }

    void Update()
    {
        timeToNextText += Time.deltaTime;

        if (timeToNextText > 1.5f)
        {
            timeToNextText = 0.0f;
            
            currentText++;
            if (currentText >= textToDisplay.Count)
            {
                currentText = 0;
            }

            text.text = textToDisplay[currentText];
        }
    }
}