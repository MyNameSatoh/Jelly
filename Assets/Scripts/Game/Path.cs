using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

public class Path : MonoBehaviour
{
    public GameObject[] waypoint;
    public Vector3 GetPosition(int index)
    {
        return waypoint[index].transform.position;
    }

    private void OnDrawGizmos()
    {
        if(waypoint.Length > 0)
        {
            for (int i = 0; i < waypoint.Length; i++)
            {
                GUIStyle style = new GUIStyle();
                style.normal.textColor = Color.black;
                style.alignment = TextAnchor.MiddleCenter;
                Handles.Label(waypoint[i].transform.transform.position + Vector3.up * 0.7f, waypoint[i].name, style);

                if (i < waypoint.Length - 1)
                {
                    Gizmos.color = Color.black;
                    Gizmos.DrawLine(waypoint[i].transform.position, waypoint[i + 1].transform.position);
                }
            }
        }
    }
}

