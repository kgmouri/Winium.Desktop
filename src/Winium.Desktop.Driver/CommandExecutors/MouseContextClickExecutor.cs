namespace Winium.Desktop.Driver.CommandExecutors
{
    #region using

    using Winium.Cruciatus.Core;

    #endregion

    internal class MouseContextClickExecutor : CommandExecutorBase
    {
        #region Methods

        protected override string DoImpl()
        {
            var registeredKey = this.ExecutedCommand.Parameters["id"].ToString();
            this.Automator.ElementsRegistry.GetRegisteredElement(registeredKey).Click(MouseButton.Right, ClickStrategies.BoundingRectangleCenter);

            return this.JsonResponse();
        }

        #endregion
    }
}
