using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveWaveManager : MonoBehaviour
{
    private List<WaveBase> WaveContainer = new List<WaveBase>();

    public void Wave(WaveBase wave)
    {
        WaveContainer.Add(wave);
    }

    public void Update()
    {
        if(WaveContainer.Count!=0)
        ManualUpdate();
    }

    private void ManualUpdate()
    {
        foreach (WaveBase wave in WaveContainer)
        {
            if (wave.CheckActiveState() == false)
            {
                WaveContainer.Remove(wave);
                break;
            }
            wave.ManualUpdate();
        }
    }
}
