using UnityEngine;

[CreateAssetMenu(fileName = "Waves", menuName = "Scriptable Objects/Waves")]
public class WavesData : ScriptableObject
{
    public EnemyType enemydata; // lấy thông in bên data để bt mà bốc con quái nào thả vô map
    public float spawninteval; //khoảng cách giữa các wave
    public float enemiesPerWave;// số enemy trong các wave
}
