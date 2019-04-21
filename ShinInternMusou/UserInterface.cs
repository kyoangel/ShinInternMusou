using GameEngine;
using ShinInternMusou.State;
using System;
using GameEngine.Role;

namespace ShinInternMusou
{
	public class UserInterface
	{
		private PlayerState _state;

		public UserInterface()
		{
			_state = new StartState();
		}

		public Character Hero { get; set; }

		public string HeroName { get; set; }

		public PlayerState State
		{
			get => _state;
			set => _state = value;
		}

		public Character Enemy { get; set; }

		public void BattleResult(Character character, Character enemy)
		{
			Console.WriteLine("");
			Console.WriteLine($"{character.Job} {character.Name} 的血量 {character.HitPoint}" +
							  $", {enemy.Name} 的血量 {enemy.HitPoint}");
		}

		public PlayerState GetState()
		{
			return _state;
		}

		public void InterAct()
		{
			this._state.InterAct(this);
		}

		public void PromptMessage(string message)
		{
			Console.WriteLine(message);
		}

		public string ReceiveMessage()
		{
			return Console.ReadLine();
		}
	}
}