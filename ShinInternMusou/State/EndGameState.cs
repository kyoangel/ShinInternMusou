namespace ShinInternMusou.State
{
	internal class EndGameState : PlayerState
	{
		public override void InterAct(UserInterface ui)
		{
			var message = ui.Enemy.HitPoint <= 0 ? "You Win!" : "You Lose!";

			ui.PromptMessage(message);
			ui.PromptMessage("Game Over, please input any key to exit.");
		}
	}
}