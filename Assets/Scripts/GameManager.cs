using Unity.VisualScripting;
using UnityEngine;

public class GameManager : ZitMonoBehaviour
{
    public static GameManager instance;
    public LibraryManager libraryManager;

    protected override void LoadComponent()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
        if (libraryManager == null) libraryManager = GameObject.Find("LibraryManager").GetComponent<LibraryManager>();
    }
}
