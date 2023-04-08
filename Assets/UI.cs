using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public static UI instance;

    public TMP_Text moneyText;
    public TMP_Text staffText;
    public TMP_Text wheatText;
    public TMP_Text melonText;
    public TMP_Text cornText;
    public TMP_Text appleText;
    public TMP_Text sellText;

    public GameObject FarmPanel;
    private void Awake()
    {
        instance = this;
    }
    

    public void UpdateHeaderPanel()
    {
        moneyText.text = GameManager.instance.money.ToString();
        staffText.text = GameManager.instance.staff.Count.ToString();
        wheatText.text = GameManager.instance.wheat.ToString();
        melonText.text = GameManager.instance.melon.ToString();
        cornText.text = GameManager.instance.corn.ToString();
        appleText.text = GameManager.instance.apple.ToString();
        sellText.text = GameManager.instance.sellAmount.ToString();
    }
    
    public void ToggleFarmPanel(bool flag)
    {
        FarmPanel.SetActive(flag);
    }

}
