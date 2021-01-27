﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFleeTransition : Transition
{
    [SerializeField] private float _attackRange;

    private void Update()
    {
        if (Vector2.Distance(transform.position, Target.transform.position) > _attackRange)
            NeedTransit = true;
    }
}
