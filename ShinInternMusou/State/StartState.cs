namespace ShinInternMusou.State
{
	internal class StartState : PlayerState
	{
		public override void InterAct(UserInterface ui)
		{
			string heroName = string.Empty;
			ui.PromptMessage("Hi hero, welcome to SHIN INTERN MUSOU, please enter your name.");
			while (string.IsNullOrEmpty(heroName))
			{
				heroName = ui.ReceiveMessage();
				if (string.IsNullOrEmpty(heroName))
				{
					ui.PromptMessage("Please input your name!");
				}
			}

			ui.PromptMessage($"Hi {heroName}, please select your class");
			ui.HeroName = heroName;

			ui.State =  new ChooseJobState();
		}
	}
}