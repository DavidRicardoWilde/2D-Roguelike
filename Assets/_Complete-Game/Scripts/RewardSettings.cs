using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "David Wilde/Reward Settings")]
    public class RewardSettings : ScriptableObject
    {
        public int ValueOfAwardByEnemy => valueOfAwardByEnemy;
        public int MaxShrubberyReward => maxShrubberyReward;
        
        [SerializeField]
        [Range(0,  50)]
        private int valueOfAwardByEnemy = 10;

        [SerializeField] [Range(1, 15)] private int valueOfAwardByTime = 5;

        [SerializeField] [Range(15, 60)] private int maxTimeToEarnReward = 30;
        
        [SerializeField] [Range(5, 15)] private int maxShrubberyReward = 5;
    }
}
