using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponIcon : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Image _icon;

    private void OnEnable()
    {
        _player.WeaponChanged += Change;
    }

    private void OnDisable()
    {
        _player.WeaponChanged -= Change;
    }

    public void Change(Weapon weapon)
    {
        _icon.sprite = weapon.Icon;
    }
}
