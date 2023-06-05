﻿using Breakout.Commands;
using Breakout.Commands.GameLost;
using Breakout.Commands.MainMenu;
using Breakout.Factories;
using Breakout.Handler;
using DIKUArcade.Input;

namespace Breakout.Controller;

public class LostGameKeyboardController : DefaultKeyboardPressHandler
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LostGameKeyboardController"/> class.
    /// </summary>
    /// <param name="menu">The default menu.</param>
    public LostGameKeyboardController(DefaultMenu menu) : base(new Dictionary<HashSet<KeyboardKey>, IKeyboardCommand>
    {
        { SetFactory.Create(KeyboardKey.Up, KeyboardKey.W), new ShiftMenuUpCommand(menu) },
        { SetFactory.Create(KeyboardKey.Down, KeyboardKey.S), new ShiftMenuDownCommand(menu) },
        { SetFactory.Create(KeyboardKey.Enter), new GameOverEnterCommand(menu, new GameEventFactory()) },
    }) { }
}