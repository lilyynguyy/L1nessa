using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject button;
    public GameObject startButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void whenButtonClicked()
    {
        one.SetActive(false);
        button.SetActive(false);
        two.SetActive(true);
        startButton.SetActive(true);

    }
    
}
