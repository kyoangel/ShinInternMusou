namespace ShinInternMusou.State
{
	internal class EndGameState : PlayerState
	{
		public override void InterAct(UserInterface ui)
		{
			if (ui.Enemy.HitPoint <= 0)
			{
				ui.PromptMessage("You Win!");
			}
			else
			{
				ui.PromptMessage("You Lose!");
			}

			ui.PromptMessage("Game Over, please input any key to exit.");
		}
	}
}