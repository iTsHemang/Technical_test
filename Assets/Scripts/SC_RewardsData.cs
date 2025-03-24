using UnityEngine;


//enum for all reward types
public enum RewardType
{
    Coins,
    XP,
    Weapons,
    Armour,
}

[CreateAssetMenu(fileName = "SC_RewardsData", menuName = "Scriptable Objects/SC_RewardsData")]
public class SC_RewardsData : ScriptableObject
{
    public int day;
    
    //arrays to store each reward info
    public RewardType[] type = new RewardType[7];
    public int[] amount = new int[7];
}
