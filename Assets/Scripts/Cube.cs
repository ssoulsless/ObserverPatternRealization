using UnityEngine;

public class Cube : MonoBehaviour
{
    void Start()
    {
        Main.onSpacePressed += DestroyThisObject;
    }
    private void DestroyThisObject()
    {
        Destroy(this.gameObject);
    }
}
