using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DIsplayRewards : MonoBehaviour
{
    //storing scriptable object
    public SC_RewardsData rewardsData;

    //arrays for each reward info
    public TextMeshProUGUI[] TDay = new TextMeshProUGUI[7];
    public TextMeshProUGUI[] TReward = new TextMeshProUGUI[7];
    public TextMeshProUGUI[] TAmount = new TextMeshProUGUI[7];

    void Start()
    {
        DisplayData();
    }

    void DisplayData()
    {
        //geting reward info from scriptable objcet and displaying on screen one by one
        for (int i = 0; i < rewardsData.day; i++)
        {
            TDay[i].text = "Day: " + (i + 1).ToString();
            TReward[i].text ="Reward: " + rewardsData.type[i].ToString();
            TAmount[i].text ="Amount:" +  rewardsData.amount[i].ToString();
        }
    }

    public void DebugInfo(int id)
    {
        //getting button id and printing reward info in debug log
        Debug.Log("Day: " + (id + 1) + ", Reward: " + rewardsData.type[id] + ", Amount: " + rewardsData.amount[id]);
    }
}
