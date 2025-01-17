﻿using System;
using UnityEngine;

public interface IControlStrategy
{
    bool Left { get; }
    bool Right { get; }
    bool Up { get; }
    bool Down { get; }
    bool WasTouched { get; }
    public void ManageInput(); 
}