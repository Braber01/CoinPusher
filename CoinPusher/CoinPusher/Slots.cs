using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace CoinPusher
{
	/// <summary>
	/// This is a game component that implements IUpdateable.
	/// </summary>
	public class Slots : Microsoft.Xna.Framework.GameComponent
	{
		enum SlotOptions
		{
			ONE = 1,
			TWO = 2,
			THREE = 3,
			FOUR = 4,
			FIVE = 5,
			SIX = 6,
			SEVEN = 7,
			EIGHT = 8,
			NINE = 9,
			BALL_GET = 10,
			JACKPOT_CHANCE = 11,
			DICE = 12
		}

		//? Should I put all the Logic for the Slots in a seprate Class?
		#region Slot_Logic

		/// <summary>
		/// Starts Slots
		/// </summary>
		/// <returns>a number of Medals Based on What the Slot match is</returns>
		public int Start_Slots()
		{
			Random rand = new Random();
			int num1 = rand.Next(1, 12);
			Random rand2 = new Random();
			int num2 = rand2.Next(1,12);
			Random rand3 = new Random();
			int num3 = rand3.Next(1, 12);

			if(num1 == num2 && num2 == num3 && num3 == num1)
			{
				//Figure out which numbers are here and do stuff according to number
				//

				if (num1 == (int)SlotOptions.ONE)
				{
					return 50;
				}
				else if (num1 == (int)SlotOptions.TWO)
				{
					return 50;
				}
				else if (num1 == (int)SlotOptions.THREE)
				{
					return 50;
				}
				else if (num1 == (int)SlotOptions.FOUR)
				{
					return 50;
				}
				else if (num1 == (int)SlotOptions.FIVE)
				{
					return 50;
				}
				else if (num1 == (int)SlotOptions.SIX)
				{
					return 50;
				}
				else if (num1 == (int)SlotOptions.SEVEN)
				{
					return 50;
				}
				else if (num1 == (int)SlotOptions.EIGHT)
				{
					return 50;
				}else if(num1 == (int)SlotOptions.NINE)
				{
					return 50;
				}else if(num1 == (int)SlotOptions.BALL_GET)
				{
					//Todo: Call function that adds a new ball on the coin pusher
					//return 50 for now
					return 50;
				}else if (num1 == (int)SlotOptions.JACKPOT_CHANCE)
				{
					//Todo: Head stright to the Grand Jackpot Chance Skipping Satlite challange
					//Return 50 for now
					return 50;
				}else if(num1 == (int)SlotOptions.DICE)
				{
					//Todo: Dice mini game
					//Return 50 for now
					return 50;
				}
				return 0;
			}
			return 0;
		}


		#endregion
		public Slots(Game game)
			: base(game)
		{
			// TODO: Construct any child components here
		}

		/// <summary>
		/// Allows the game component to perform any initialization it needs to before starting
		/// to run.  This is where it can query for any required services and load content.
		/// </summary>
		public override void Initialize()
		{
			// TODO: Add your initialization code here

			base.Initialize();
		}

		/// <summary>
		/// Allows the game component to update itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		public override void Update(GameTime gameTime)
		{
			// TODO: Add your update code here

			base.Update(gameTime);
		}
	}
}
