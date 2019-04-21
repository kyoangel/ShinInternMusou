using System;
using GameEngine;
using GameEngine.Enum;
using GameEngine.Role;

namespace ShinInternMusou.State
{
	internal class BattleState : PlayerState
	{
		public override void InterAct(UserInterface ui)
		{
			ui.PromptMessage($"Hi {ui.Hero.Job} {ui.Hero.Name}, there is a goblin");
			ui.PromptMessage("Please defeat him");
			ui.PromptMessage("");

			ui.Enemy = CharacterFactory.CreateEnemy("Goblin");
			while (ui.Hero.HitPoint > 0 && ui.Enemy.HitPoint > 0)
			{
				ui.PromptMessage("type [Attack], [Skill] to fight, type [Run] for retreat");
				var combat = ui.ReceiveMessage();
				Enum.TryParse(combat, true, out CombatAction action);
				switch (action)
				{
					case CombatAction.Run:
						ui.PromptMessage("You Lose!");
						break;

					case CombatAction.Attack:
						ui.Hero.Attack(ui.Enemy);
						ui.Enemy.Attack(ui.Hero);
						break;

					case CombatAction.Skill:
						if (ui.Hero is IHero)
						{
							(ui.Hero as IHero).Skill(ui.Enemy);
						}
						else
						{
							ui.PromptMessage("You don't have skill");
						}

						ui.Enemy.Attack(ui.Hero);
						break;

					default:

						ui.PromptMessage("Your Action is not valid.");
						ui.PromptMessage("type [Attack], [Skill] to fight, type [Run] for retreat");
						break;
				}

				ui.BattleResult(ui.Hero, ui.Enemy);
				Console.WriteLine();
			}

			ui.State = new EndGameState();
		}
	}
}