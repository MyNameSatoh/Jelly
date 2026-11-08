using UnityEngine;

public class ZitMonoBehaviour : MonoBehaviour
{
    protected virtual void Awake()
    {
        LoadComponent();
    }
    protected virtual void Reset()
    {
        LoadComponent();
    }
    protected virtual void LoadComponent()
    {
    }
}
