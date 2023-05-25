﻿using Breakout.PowerUps;
using Breakout.States.GameRunning;
using Breakout.Utility;
using DIKUArcade.Graphics;
using DIKUArcade.Math;

namespace Breakout.Entities.PowerUps;

public class BigBallPowerUp : IPowerUpType
{
    public IBaseImage GetImage()
    {
        return new Image(Path.Combine("Assets", "Images", "BigPowerUp.png"));
    }

    public void DropPowerUp(BlockEntity block)
    {
        float positionX = block.Shape.Position.X + block.Shape.Extent.X / 2 - PositionUtil.PowerUpExtent.X / 2;
        float positionY = block.Shape.Position.Y + block.Shape.Extent.Y / 2 - PositionUtil.PowerUpExtent.Y / 2;

        var position = new Vec2F(positionX, positionY);
        var powerUp = PowerUpEntity.Create(position, "BigPowerUp", new BigBallPowerUpActivator(GameRunningState.GetInstance().EntityManager));
        GameRunningState.GetInstance().EntityManager.PowerUpEntities.AddEntity(powerUp);
    }
}