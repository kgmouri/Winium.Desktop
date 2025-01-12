﻿namespace Winium.Desktop.Driver.CommandExecutors
{
    #region using

    using Winium.Cruciatus;
    using Winium.Cruciatus.Core;

    #endregion

    internal class MouseDoubleClickExecutor : CommandExecutorBase
    {
        #region Methods

        protected override string DoImpl()
        {
            var registeredKey = this.ExecutedCommand.Parameters["id"].ToString();
            this.Automator.ElementsRegistry.GetRegisteredElement(registeredKey).DoubleClick(MouseButton.Left, ClickStrategies.BoundingRectangleCenter);

            return this.JsonResponse();
        }

        #endregion
    }
}
