using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _stageselectButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _exitButton;
    [SerializeField] Button _creditsButton;
    // Start is called before the first frame update
    void Start()
    {
        _stageselectButton.onClick.AddListener(delegate { StageSelectButtonClick(_stageselectButton); });
        _optionsButton.onClick.AddListener(delegate { OptionsButtonClick(_optionsButton); });
        _exitButton.onClick.AddListener(delegate { ExitButtonClick(_exitButton); });
        _creditsButton.onClick.AddListener(delegate { CreditsButtonClick(_creditsButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StageSelectButtonClick(Button button)
    {
        if (!GameApplicationManager.Instance.IsStagesSelectActive)
        {
            SceneManager.LoadScene("SceneStages", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsStagesSelectActive = true;
        }
    }
    public void OptionsButtonClick(Button button)
    {
        if (!GameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }
    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }
    public void CreditsButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneCredits");
    }
}
