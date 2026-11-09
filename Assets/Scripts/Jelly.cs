using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;

public class Jelly : Object
{
    [SerializeField] private bool isDetected = false;
    [SerializeField] private int direction = 1;// include clockwise and  counterclockwise
    [SerializeField] private float count = 0;
    public override void Attack(Object target)
    {
        base.Attack(target);
    }
    private void Update()
    {
        Spin();
        count += Time.deltaTime;
    }
    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (!collider2D.gameObject.GetComponent<enemy>()) return;
        isDetected = false;
    }
    private void OnTriggerStay2D(Collider2D collider2D)
    {
        if (!collider2D.gameObject.GetComponent<enemy>()) return;
        isDetected = true;
    }
    public void Spin()
    {
        if (!isDetected) return;
        if (count >= 0.7f)
        {
            count = 0;
            direction *= -1;
        }
        transform.Rotate(attributes.speed * Time.deltaTime * new Vector3(0,0,1) * direction);
    }
}
