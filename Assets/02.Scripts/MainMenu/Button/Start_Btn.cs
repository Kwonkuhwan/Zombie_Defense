using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_Btn : MonoBehaviour
{
    private Button startBtn = null;

    protected void Awake()
    {
        startBtn = GetComponent<Button>();
        startBtn.onClick.AddListener(OnClickButton);
    }

    public void OnClickButton()
    {
        SceneManager.LoadSceneAsync("01.LoadingScene");
    }


}
