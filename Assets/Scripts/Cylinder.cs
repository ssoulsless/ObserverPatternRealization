using UnityEngine;

public class Cylinder : MonoBehaviour
{
    void Start()
    {
        Main.onSpacePressed += ChangeColor;
    }
    private void ChangeColor()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
