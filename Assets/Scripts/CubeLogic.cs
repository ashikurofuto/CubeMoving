using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    [SerializeField] private CubeData data;
    private Vector3 startPoint;
    private float cubeSpeed;
    private float maxDistance;
    private Rigidbody rigidbody;


    private void Start()
    {
        cubeSpeed = data.Speed;
        maxDistance = data.Distance;
        rigidbody = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        startPoint = Vector3.zero;
        transform.position = startPoint;
    }

    private void Update()
    {
        Moving(cubeSpeed, maxDistance);
    }
    private void Moving(float Speed,float Distance)
    {
        if (Vector3.Distance(transform.position, startPoint) < Distance)
        {
            rigidbody.AddForce(Vector3.right * cubeSpeed * Time.deltaTime, ForceMode.Force);
        }
        else
        {
            this.gameObject.SetActive(false);
            
        }

    }
}
