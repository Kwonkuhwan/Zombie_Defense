using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close_Btn : ButtonParent
{
   private Button closeBtn = null;

    protected override void Awake()
    {
        base.Awake();
        closeBtn = GetComponent<Button>();
        closeBtn.onClick.AddListener(OnClickButton);
    }

    public void OnClickButton()
    {
        OnCanvasGroupSetting(true, false, false);
    }
}
