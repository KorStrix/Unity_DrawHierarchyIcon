using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HierachyIconDrawer_Example : MonoBehaviour, IDraw_HierarchyIcon
{
    public Texture2D[] arrNumberTexture;

    public int _iCount;

    void OnEnable()
    {
        StartCoroutine(CoUpdateNumber());
    }

    IEnumerator CoUpdateNumber()
    {
        _iCount = 0;

        while (true)
        {
            yield return new WaitForSeconds(0.2f);

            _iCount++;
        }
    }


    public void IDraw_HierarchyIcon_GetIcon(ref List<DrawIconInfo> listDrawIconInfo_DefaultCount_IsZero)
    {
        if (_iCount > 100)
        {
            int iNumber_Hundread = _iCount / 100;
            if(iNumber_Hundread < arrNumberTexture.Length)
                listDrawIconInfo_DefaultCount_IsZero.Add(new DrawIconInfo(arrNumberTexture[iNumber_Hundread], 100));
        }


        if (_iCount > 10)
        {
            int iNumber_Ten = _iCount / 10;
            if (iNumber_Ten < arrNumberTexture.Length)
                listDrawIconInfo_DefaultCount_IsZero.Add(new DrawIconInfo(arrNumberTexture[iNumber_Ten], 10));
        }

        int iNumber_One = _iCount % 10;
        if (iNumber_One < arrNumberTexture.Length)
            listDrawIconInfo_DefaultCount_IsZero.Add(new DrawIconInfo(arrNumberTexture[iNumber_One], 0));
    }
}
