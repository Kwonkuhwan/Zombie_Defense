using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonParent : MonoBehaviour
{
    public GameObject buttonPanel = null;
    protected CanvasGroup buttonCanvasGroup = null;

    public GameObject storePanel = null;
    protected CanvasGroup storeCanvasGroup = null;

    public GameObject optionPanel = null;
    protected CanvasGroup optionCanvasGroup = null;


    protected virtual void Awake()
    {
        if (buttonPanel == null)
            buttonPanel = GameObject.Find("Button_Panel");
        buttonCanvasGroup = buttonPanel.GetComponent<CanvasGroup>();        // Button_Panel의 캔버스 그룹

        if (storePanel == null)
            storePanel = GameObject.Find("Store_Panel");
        storeCanvasGroup = storePanel.GetComponent<CanvasGroup>();        // Store_Panel의 캔버스 그룹

        if (optionPanel == null)
            optionPanel = GameObject.Find("Option_Panel");
        optionCanvasGroup = optionPanel.GetComponent<CanvasGroup>();        // Option_Panel의 캔버스 그룹
    }

    protected virtual void OnCanvasGroupSetting(bool _start, bool _store, bool _option)
    {
        if (_start)
        {
            buttonCanvasGroup.alpha = 1;
            buttonCanvasGroup.interactable = true;
            buttonCanvasGroup.blocksRaycasts = true;
        }
        else
        {
            buttonCanvasGroup.alpha = 0;
            buttonCanvasGroup.interactable = false;
            buttonCanvasGroup.blocksRaycasts = false;
        }

        if (_store)
        {
            storeCanvasGroup.alpha = 1;
            storeCanvasGroup.interactable = true;
            storeCanvasGroup.blocksRaycasts = true;
        }
        else
        {
            storeCanvasGroup.alpha = 0;
            storeCanvasGroup.interactable = false;
            storeCanvasGroup.blocksRaycasts = false;
        }

        if (_option)
        {
            optionCanvasGroup.alpha = 1;
            optionCanvasGroup.interactable = true;
            optionCanvasGroup.blocksRaycasts = true;
        }
        else
        {
            optionCanvasGroup.alpha = 0;
            optionCanvasGroup.interactable = false;
            optionCanvasGroup.blocksRaycasts = false;
        }
    }
}
