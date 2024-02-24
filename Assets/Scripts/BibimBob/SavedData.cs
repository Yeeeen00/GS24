using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Rice
{
    WhiteRice,
    BeanRice,
    HyunMeRice
}

public class SavedData : MonoBehaviour
{
    #region ΩÃ±€≈Ê ∆–≈œ
    private static SavedData _instance;
    public static SavedData Ins
    {
        get { 
            if(_instance == null)
            {
                _instance = new GameObject("SavedData").AddComponent<SavedData>();
            }
            return _instance;
        }
    }
    #endregion

    public Rice curRice = 0;
}
