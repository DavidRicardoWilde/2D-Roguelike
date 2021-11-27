using System;
using System.Collections;
using System.Collections.Generic;
using Data;
using UnityEngine;

public class RewardManager : MonoBehaviour
{
    public RewardSettings RewardSettings => rewardSettings;
    [SerializeField] private RewardSettings rewardSettings;
    
    [SerializeField]
    private int valueOfAwardByEnemy = 10; //每个敌人获取的奖励值
    [SerializeField]
    private int valueOfAwardByTime = 5;//基于时间获得的奖励
    [SerializeField]
    private int maxTimeToEarnReward = 30;
    public int MaxTimeToEarnReward => maxTimeToEarnReward;

    public string rewardMessage = null;
    
    public bool IsRewarding { get; private set; } = true;

    public void SetIsReward(bool value)
    {
        IsRewarding = value;
    }

    // TODO: instance
    // public static RewardManager instance { get; private set; }
    //
    // private void Awake()
    // {
    //     // throw new NotImplementedException();
    //     
    // }
}
