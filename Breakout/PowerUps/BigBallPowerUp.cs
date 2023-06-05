﻿using Breakout.PowerUps.Activators;
using Breakout.States.GameRunning;
using DIKUArcade.Graphics;

namespace Breakout.PowerUps;

/// <summary>
/// Represents the Big Ball Power-Up.
/// </summary>
public class BigBallGameModifier : IGameModifier
{
    /// <summary>
    /// Gets the image associated with the Big Ball Power-Up.
    /// </summary>
    /// <returns>The image of the Big Ball Power-Up.</returns>
    public IBaseImage GetImage() => 
        new Image(Path.Combine("Assets", "Images", "BigPowerUp.png"));


    /// <summary>
    /// Gets the activator for the Big Ball Power-Up.
    /// </summary>
    /// <returns>The activator for the Big Ball Power-Up.</returns>
    public IGameModifierActivator Activator() =>
        new BigBallGameModifierActivator(GameRunningState.GetInstance().EntityManager);
}