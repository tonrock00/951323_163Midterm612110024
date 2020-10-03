using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLose1ControlScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button _backtomenuButton;

    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackButtonClick(_backButton); });
        _backtomenuButton.onClick.AddListener(delegate { BackMainmenuButtonClick(_backtomenuButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneLoseStage1");
        SceneManager.LoadScene("SceneStages");
    }
    public void BackMainmenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneLoseStage1");
        SceneManager.LoadScene("SceneMainmenu");
    }
}
