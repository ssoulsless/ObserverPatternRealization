using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Transform _transform;
    private void Awake()
    {
        _transform = gameObject.GetComponent<Transform>();
    }
    void Start()
    {
        Main.onSpacePressed += ChangePosition;
    }
    private void ChangePosition()
    {
        _transform.position = new Vector3(_transform.position.x, _transform.position.y + 5, _transform.position.z);
    }
}
