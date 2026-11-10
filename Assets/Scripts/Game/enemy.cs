using UnityEngine;

public class enemy : Object
{
    [SerializeField] private EnemyData data;
    private Path _currentPath;
    private Vector3 _targetPosition;
    private int _currentwaypoint;
    protected override void Awake()
    {
        _currentPath = GameObject.Find("Path1").GetComponent<Path>();
    }
    private void OnEnable()
    {
        _currentwaypoint = 0;
        _targetPosition = _currentPath.GetPosition(_currentwaypoint);
        
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, data.speed * Time.deltaTime);
        float relativeDistance = (transform.position - _targetPosition).magnitude;
        if (relativeDistance < 0.1f)
        {
            if (_currentwaypoint < _currentPath.waypoint.Length - 1)
            {
                _currentwaypoint++;
                _targetPosition = _currentPath.GetPosition(_currentwaypoint);
            }
            else
            {
                gameObject.SetActive(false);
            }

        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.GetComponent<Base>()) return;
        collision.gameObject.GetComponent<Object>().ReceiveDamage(this);
    }
}
