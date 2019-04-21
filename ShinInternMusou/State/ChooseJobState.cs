using System;
using GameEngine;
using GameEngine.Enum;
using GameEngine.Role;

namespace ShinInternMusou.State
{
	internal class ChooseJobState : PlayerState
	{
		public override void InterAct(UserInterface ui)
		{
			Character character = null;
			while (character == null)
			{
				ui.PromptMessage("type [Novice], [Warrior], or [Priest] to create you character");
				var classChoose = ui.ReceiveMessage();
				Enum.TryParse(classChoose, true, out HeroClass heroClass);
				try
				{
					character = CharacterFactory.CreateCharacter(ui.HeroName, heroClass);
				}
				catch (ArgumentOutOfRangeException e)
				{
					Console.WriteLine("the job you type is not valid");
				}
			}

			ui.Hero = character;

			ui.State = new BattleState();
		}
	}
}