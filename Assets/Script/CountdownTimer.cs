using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    [SerializeField ]float startingTime = 40f;

    [SerializeField] public Text _countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        _countdownText.text = currentTime.ToString(".0");

        if(currentTime < 0.0f)
        {
            SceneManager.UnloadSceneAsync("SceneStage1");
            SceneManager.LoadScene("SceneLoseStage1");
        }
    }
}
