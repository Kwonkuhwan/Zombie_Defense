using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option_Btn : ButtonParent
{
    private Button optionBtn = null;

    protected override void Awake()
    {
        base.Awake();
        optionBtn = GetComponent<Button>();
        optionBtn.onClick.AddListener(OnClickButton);
    }

    public void OnClickButton()
    {
        OnCanvasGroupSetting(false, false, true);
    }
}
