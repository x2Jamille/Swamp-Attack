﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextWave : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Button _nextWaveButton;

    private void OnEnable()
    {
        _spawner.AllEnemySpawned += OnAlleEnemySpawned;
        _nextWaveButton.onClick.AddListener(OnNextWaveButtonClick);
    }

    private void OnDisable()
    {
        _spawner.AllEnemySpawned -= OnAlleEnemySpawned;
        _nextWaveButton.onClick.RemoveListener(OnNextWaveButtonClick);
    }

    public void OnAlleEnemySpawned()
    {
        _nextWaveButton.gameObject.SetActive(true);
    }

    public void OnNextWaveButtonClick()
    {
        _spawner.NextWave();
        _nextWaveButton.gameObject.SetActive(false);
    }
}
