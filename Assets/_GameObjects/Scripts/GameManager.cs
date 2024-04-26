using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    private int enemiesCounter = 0;
    public TextMeshProUGUI textEnemiesCounter;
    public void AddEnemy()
    {
        enemiesCounter++;
        UpdateEnemiesCounter();
    }
    public void RemoveEnemy()
    {
        enemiesCounter--;
        UpdateEnemiesCounter();
    }
    private void UpdateEnemiesCounter()
    {
        if (textEnemiesCounter)
        {
            textEnemiesCounter.text = enemiesCounter.ToString();
        }
    }
}
