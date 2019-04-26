#region Header
/*	============================================
 *	작성자 : Strix
 *	작성일 : 2019-04-24 오전 11:08:53
 *	개요 : 
   ============================================ */
#endregion Header

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

#if UNITY_EDITOR
using UnityEditor;

using static HierachyIconList;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(menuName = "StrixSO/" + nameof(HierachyIconConfig))]
public class HierachyIconConfig : CSingletonSOBase<HierachyIconConfig>
{
    public HierachyIconList[] arrIconMapping;

    static Dictionary<string, IconMappingDataBase> mapIconPer_Type = new Dictionary<string, IconMappingDataBase>();
    static Dictionary<string, IconMappingDataBase> mapIconPer_Tag = new Dictionary<string, IconMappingDataBase>();

    static public bool GetTexture_Per_Type(System.Type pType, ref Texture2D pTexture, ref int iOrder)
    {
        IconMappingDataBase sValue;
        if (mapIconPer_Type.TryGetValue(pType.GetFriendlyName(), out sValue))
        {
            pTexture = sValue.GetTexture();
            iOrder = sValue.iOrder;

            return pTexture != null;
        }
        else
        {
            pTexture = null;
            iOrder = 0;

            return false;
        }
    }

    static public bool GetTexture_Per_Tag(string strTag, ref Texture2D pTexture, ref int iOrder)
    {
        IconMappingDataBase sValue;
        if (mapIconPer_Tag.TryGetValue(strTag, out sValue))
        {
            pTexture = sValue.GetTexture();
            iOrder = sValue.iOrder;

            return pTexture != null;
        }
        else
        {
            pTexture = null;
            iOrder = 0;

           return false;
        }
    }

    protected override void OnAwake(bool bAppIsPlaying)
    {
        base.OnAwake(bAppIsPlaying);

        UpdateIcon();
    }

#if ODIN_INSPECTOR
    [Button]
#endif
    public void UpdateIcon()
    {
        mapIconPer_Type.Clear();
        mapIconPer_Tag.Clear();

        if (arrIconMapping == null)
            return;

        for (int i = 0; i < arrIconMapping.Length; i++)
        {
            for (int j = 0; j < arrIconMapping[i].p_listIconMappingData_Type.Count; j++)
                mapIconPer_Type.Add(arrIconMapping[i].p_listIconMappingData_Type[j].strTypeName, arrIconMapping[i].p_listIconMappingData_Type[j]);

            for (int j = 0; j < arrIconMapping[i].p_listIconMappingData_Tag.Count; j++)
                mapIconPer_Tag.Add(arrIconMapping[i].p_listIconMappingData_Tag[j].strTag, arrIconMapping[i].p_listIconMappingData_Tag[j]);
        }
    }
}
#endif