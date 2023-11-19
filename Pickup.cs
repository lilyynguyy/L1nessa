using System;
using System.Collections;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    private int scoreCount;
    public TextMeshProUGUI scoreText;
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */
    // Update is called once per frame
    void Update()
    {

    }
    
    void OnMouseDown()
    {
        
        scoreCount++;
        scoreText.text = scoreCount.ToString();
        
        Destroy(gameObject);
        //renderer.enabled = false;
    }
}

