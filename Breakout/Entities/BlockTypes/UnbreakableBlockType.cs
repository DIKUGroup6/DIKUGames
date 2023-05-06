using DIKUArcade.Math;
using DIKUArcade.Entities;
using DIKUArcade.Graphics;

namespace Breakout.Entities.BlockTypes;

/// <summary>
/// Defines the class for the special block type unbreakable block from the interface IBlockTypes/// The block should not be able to take damage
/// </summary>
public class UnbreakableBlockType : IBlockType
{
    #region Methods
    /// <summary>
    /// A method of handling collision between the block and the ball entity
    /// </summary>
    /// <param name="block">The blockentity</param>
    void IBlockType.CollisionHandler(BlockEntity block) 
    {
        // do nothing upon collision
    }
    #endregion
}