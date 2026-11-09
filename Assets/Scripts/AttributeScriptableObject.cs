using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "NewAttributeData", menuName = "Game Data/Attribute Scriptable Object", order = 0)]
public class AttributeScriptableObject : ScriptableObject
{
    public LibraryManager.ObjectAttributes attributes; //initial attribute, which will set up mob's stats
}
