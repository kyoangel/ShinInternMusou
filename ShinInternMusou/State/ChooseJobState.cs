using GameEngine;
using GameEngine.Enum;
using System;

namespace ShinInternMusou.State
{
	internal class ChooseJobState : PlayerState
	{
		public override void InterAct(UserInterface ui)
		{
			ui.PromptMessage($"Hi {ui.HeroName}, please select your class");
			ui.PromptMessage("Type [Novice], [Warrior], or [Priest] to create you character");

			var classChoose = ui.ReceiveMessage();
			if (classChoose.Equals("Rename", StringComparison.OrdinalIgnoreCase))
			{
				ui.State = new StartState();
				return;
			}

			Enum.TryParse(classChoose, true, out HeroClass heroClass);
			try
			{
				ui.Hero = CharacterFactory.CreateCharacter(ui.HeroName, heroClass);
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("The job you type is not valid");
				return;
			}

			ui.State = new BattleState();
		}
	}
}