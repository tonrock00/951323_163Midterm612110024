using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneWinStage1ControlScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button _nextButton; 
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackButtonClick(_backButton); });
        _nextButton.onClick.AddListener(delegate { NextButtonClick(_nextButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneWinStage1");
        SceneManager.LoadScene("SceneStages");
    }
    public void NextButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneWinStage1");
        SceneManager.LoadScene("SceneStage2");
    }
}