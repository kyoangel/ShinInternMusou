using GameEngine;
using GameEngine.Enum;
using GameEngine.Role;
using System;

namespace ShinInternMusou.State
{
	internal class BattleState : PlayerState
	{
		public override void InterAct(UserInterface ui)
		{
			if (ui.Enemy == null)
			{
				BattleOpening(ui);
			}

			ui.PromptMessage("Type [Attack], [Skill] to fight, [Run] for retreat");
			Enum.TryParse(ui.ReceiveMessage(), true, out CombatAction action);
			switch (action)
			{
				case CombatAction.Run:
					ui.PromptMessage("You Lose!");
					ui.State =  new EndGameState();
					break;

				case CombatAction.Attack:
					ui.Hero.Attack(ui.Enemy);
					ui.Enemy.Attack(ui.Hero);
					break;

				case CombatAction.Skill:
					if (ui.Hero is IHero hero)
					{
						hero.Skill(ui.Enemy);
					}
					else
					{
						ui.PromptMessage("You don't have skill");
					}

					ui.Enemy.Attack(ui.Hero);
					break;

				default:

					ui.PromptMessage("Your action is not valid.");
					break;
			}

			ui.BattleResult(ui.Hero, ui.Enemy);
			Console.WriteLine();

			if (HasResult(ui))
			{
				ui.State = new EndGameState();
			}
		}

		private static void BattleOpening(UserInterface ui)
		{
			ui.PromptMessage($"Hi {ui.Hero.JobTitle} {ui.Hero.Name}, there is a goblin");
			ui.PromptMessage("Please defeat him");
			Console.WriteLine();
			ui.Enemy = CharacterFactory.CreateEnemy("Goblin");
		}

		private static bool HasResult(UserInterface ui)
		{
			return ui.Hero.HitPoint <= 0 || ui.Enemy.HitPoint <= 0;
		}
	}
}