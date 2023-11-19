using System;
using System.Collections;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public GameObject shark;
    public GameObject whale;
    public GameObject fish;
    private int scoreCount;
    public TextMeshProUGUI scoreText;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            scoreCount++;
            scoreText.text = scoreCount.ToString();

        }
        if (scoreCount == 3)
        {
            shark.SetActive(true);
        }
        else if (scoreCount == 6)
        {
            whale.SetActive(true);
        }
        else if (scoreCount == 10)
        {
            fish.SetActive(true);
            Invoke("SwitchScene", 3);
            
        }
    }
    public void SwitchScene()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(2);
    }
}
