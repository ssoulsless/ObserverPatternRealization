using UnityEngine;

public class Capsule : MonoBehaviour
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
