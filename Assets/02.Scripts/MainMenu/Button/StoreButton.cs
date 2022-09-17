using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreButton : ButtonParent
{
    private Button storeButton = null;
    protected override void Awake()
    {
        base.Awake();
        storeButton = GetComponent<Button>();
        storeButton.onClick.AddListener(OnClickButton);
    }

    public void OnClickButton()
    {
        OnCanvasGroupSetting(false, true, false);
    }
}
