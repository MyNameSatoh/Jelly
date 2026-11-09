using UnityEngine;

public class enemy : Object
{
    [SerializeField] private float MoveSpeed = 1f;
    [SerializeField] private Path currentPath;
    private Vector3 _targetPosition;
    private int _currentwaypoint;
    private void Awake()
    {
        currentPath = GameObject.Find("Path1").GetComponent<Path>();
    }
    private void OnEnable()
    {
        _currentwaypoint = 0;
        _targetPosition = currentPath.GetPosition(_currentwaypoint);
        
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, MoveSpeed * Time.deltaTime);
        float relativeDistance = (transform.position - _targetPosition).magnitude;
        if (relativeDistance < 0.1f)
        {
            if (_currentwaypoint < currentPath.waypoint.Length - 1)
            {
                _currentwaypoint++;
                _targetPosition = currentPath.GetPosition(_currentwaypoint);
            }
            else
            {
                Destroy(gameObject);
            }

        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.GetComponent<Base>()) return;
        collision.gameObject.GetComponent<Object>().ReceiveDamage(this);
    }
}
