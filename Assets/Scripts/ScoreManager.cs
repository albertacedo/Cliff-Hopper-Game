using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance { get; private set; }

    int numCoins, numJumps;

    [SerializeField] private TextMeshProUGUI coins, jumps;


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        numCoins = numJumps = 0;

    }

    public void addScore()
    {
        ++numCoins;
        coins.text = numCoins.ToString();
    }

    public void addJump()
    {
        ++numJumps;
        jumps.text = numJumps.ToString();

    }
}
