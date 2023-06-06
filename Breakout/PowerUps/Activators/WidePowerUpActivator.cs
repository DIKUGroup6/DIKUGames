﻿using Breakout.Entities;
using DIKUArcade.Math;

namespace Breakout.PowerUps.Activators;

/// <summary>
/// Represents an activator for the Wide Power-Up.
/// </summary>
public class WidePowerUpActivator : IPowerUpActivator
{
    private readonly PlayerEntity _playerEntity;

    /// <summary>
    /// Initializes a new instance of the WidePowerUpActivator class.
    /// </summary>
    /// <param name="playerEntity">The PlayerEntity instance.</param>
    public WidePowerUpActivator(PlayerEntity playerEntity)
    {
        _playerEntity = playerEntity;
    }
    
    /// <summary>
    /// Activates the Wide Power-Up by multiplying the player's extent in the x-axis,
    /// making the player wider.
    /// </summary>
    public void Activate()
    {
        _playerEntity.MultiplyExtent(new Vec2F(1.5f, 1.0f));
        Task.Delay(5000).ContinueWith(t => _playerEntity.MultiplyExtent(new Vec2F(1/1.5f, 1.0f)));
    }
}