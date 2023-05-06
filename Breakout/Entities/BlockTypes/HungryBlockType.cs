using DIKUArcade.Math;
using DIKUArcade.Entities;
using DIKUArcade.Graphics;
using Breakout.Entities.BlockTypes;

namespace Breakout.Entities.Blocks;

/// <summary>
/// Defines the class for the special block type hungry block from the interface IBlockTypes
/// The block should be able to consume the ball upon colission 
/// </summary>
public class HungryBlockType : IBlockType 
{
    #region Methods
    /// <summary>
    /// A method of handling collision between the block and the ball entity
    /// </summary>
    /// <param name="block">The blockentity</param>
    void IBlockType.CollisionHandler(BlockEntity block) 
    {
        block.TakeDamage();
        // should "eat" the ball, by deleting it and spawning it a random place on the map
    }
    #endregion
}