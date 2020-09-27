using UnityEngine;

public class Main : MonoBehaviour
{
    private Main _instance;
    public Main Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Main is NULL!!!");
            return _instance;
        }
    }
    public delegate void OnSpacePressed();
    public static event OnSpacePressed onSpacePressed;

    private void Awake()
    {
        _instance = this;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onSpacePressed != null)
                onSpacePressed();
        }
    }

}

