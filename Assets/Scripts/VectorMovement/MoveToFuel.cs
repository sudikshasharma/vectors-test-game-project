using UnityEngine;

public class MoveToFuel : MonoBehaviour
{
    public Transform Fuel;
    private Vector3 pos;
    void Start()
    {
        pos = (Fuel.position - this.transform.position);
    }

    void Update()
    {
        this.transform.position += pos * 0.1f;
        pos = Fuel.position - this.transform.position;
    }
}
