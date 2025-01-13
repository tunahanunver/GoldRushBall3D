using UnityEngine;

namespace Runtime.Data.ValueObjects
{
    [CreateAssetMenu(fileName = "CD_Player", menuName = "GoldRushBall3D/CD_Player", order = 0)]

    public class CD_Player : ScriptableObject
    {
        public PlayerData Data;
    }
}