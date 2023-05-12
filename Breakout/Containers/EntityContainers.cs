﻿using Breakout.Entities;
using Breakout.States;
using Breakout.Utility;
using DIKUArcade.Entities;
using DIKUArcade.Math;

namespace Breakout.Containers;

public class EntityManager
{
    private readonly GameRunningState _state;
    public EntityContainer<BlockEntity> BlockEntities { get; set; }
    public EntityContainer<BallEntity> BallEntities { get; }
    public PlayerEntity PlayerEntity { get; }

    public EntityManager(GameRunningState state)
    {
        _state = state;
        PlayerEntity = PlayerEntity.Create();
        BlockEntities = new EntityContainer<BlockEntity>();
        BallEntities = new EntityContainer<BallEntity>();
    }

    public void RenderEntities()
    {
        BlockEntities.RenderEntities();
        BallEntities.RenderEntities();
        PlayerEntity.RenderEntity();
    }

    public void Move()
    {
        PlayerEntity.Move();
        BallEntities.Iterate(ball =>
        {
            CollisionProcessor.CheckBlockCollisions(BlockEntities, ball, PlayerEntity, _state);
            CollisionProcessor.CheckBallPlayerCollision(ball, PlayerEntity);
            if (ball.OutOfBounds())
            {
                ball.DeleteEntity(); //Iterate lets us mutate the container while iterating
                PlayerEntity.TakeLife();
                _state.UpdateText();
                AddBallEntity(BallEntity.Create(PlayerEntity.Shape.Position + PlayerEntity.Shape.Extent / 2, ConstantsUtil.BallExtent,
                    ConstantsUtil.BallSpeed, ConstantsUtil.BallDirection * new Vec2F(1f, -1f)));
            }
            ball.Move();
        });
    }

    public void AddBallEntity(BallEntity ballEntity)
    {
        BallEntities.AddEntity(ballEntity);
    }
    
    public void AddBlockEntity(BlockEntity blockEntity)
    {
        BlockEntities.AddEntity(blockEntity);
    }
    
}