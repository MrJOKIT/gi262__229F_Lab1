using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    private int _id;
    private int charSkinId;
    public GameObject[] charSkin;
    public string staffName;
    public int dailyWage;
    
    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public int CharSkinID
    {
        get { return charSkinId; }
        set { charSkinId = value; }
    }

    public void InitCharID(int id)
    {
        this._id = id;
        this.charSkinId = Random.Range(0, charSkin.Length -1);
        staffName = "XXXXX";
        dailyWage = Random.Range(80, 125);
        ChangeCharSkin();
        
    }

    public void ChangeCharSkin()
    {
        for (int i = 0; i < charSkin.Length; i++)
        {
            if (i == charSkinId)
            {
                charSkin[i].SetActive(true);
            }
            else
            {
                charSkin[i].SetActive(false);
            }
        }
    }
    
}
