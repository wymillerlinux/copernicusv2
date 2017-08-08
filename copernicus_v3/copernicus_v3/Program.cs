using System;
using System.Diagnostics;

namespace copernicus_v3
{
	class MainClass
	{
		const double MATH_PI = 3.14159;

		public static void Main (string[] args)
		{
			WelcomePrompt ();
			MainMenu ();
		}

		static void MainMenu(){
			HeaderPrompt ("Main Menu");

			Console.WriteLine ("Please select an option with the cooresponding number:");
			Console.WriteLine ("1. Calculate");
			Console.WriteLine ("2. Convert");
			Console.WriteLine ("3. Credits");
			Console.WriteLine ("4. Help");
			Console.WriteLine ("5. Exit");
			Console.Write ("ENTER A FIGURE: ");
			string userResponse = Console.ReadLine ();

			switch (userResponse) {
			case "1":
				CalculateMenu ();
				break;
			case "2":
				ConvertMenu ();
				break;
			case "3":
				Credits();
				break;
			case "4":
				Help ();
				break;
			case "5":
				Exit ();
				Environment.Exit (0);
				break;
			case "e":
				Exit ();
				break;
			default:
				Console.Clear ();
				Console.WriteLine ("You didn't enter a vaild figure, please try again!");
				ContinuePrompt ();
				MainMenu ();
				break;
			}
		}

		static void ContinuePrompt(){
			Console.WriteLine ();
			Console.WriteLine ("Press any key to continue...");
			Console.ReadKey ();
		}

		static void WelcomePrompt(){
			Console.WriteLine ("\tWelcome to Copernicus, a physics calculator!");
			Console.WriteLine ();
			Console.WriteLine ("\tNow with Convert, an option to let you convert any height, length\t");
			Console.WriteLine ("\tor force with ease!");
			ContinuePrompt ();
		}

		static void CalculateMenu(){
			HeaderPrompt ("Calculate Menu");
			Console.WriteLine ("What kind of physics problem would you like to solve?");
			Console.WriteLine ("1) Mechanics");
			Console.WriteLine ("2) Thermal");
			Console.WriteLine ("3) Waves/Optics");
			Console.WriteLine ("4) Electricity/Magnetism");
			Console.WriteLine ("5) Modern/Theoretical");
			Console.Write ("ENTER A FIGURE: ");
			string userResponse = Console.ReadLine ();

			switch (userResponse) {
			case "1":
				MechMenu ();
				break;
			case "2":
				ThermMenu ();
				break;
			case "3":
				WavesOpticsMenu ();
				break;
			case "4":
				ElecMagMenu ();
				break;
			case "5":
				ModernMenu ();
				break;
			case "e":
				MainMenu ();
				break;
			default:
				Console.Clear ();
				Console.WriteLine ("You didn't enter a vaild figure, please try again!");
				ContinuePrompt ();
				CalculateMenu ();
				break;
			}
			//ContinuePrompt ();
			//MainMenu ();
		}

		#region **Diversion of physics problems**
		static void MechMenu(){
			HeaderPrompt ("Mechanics");
			Console.WriteLine ("Which problem would you like to solve?");
			Console.WriteLine ("1) Velocity");
			Console.WriteLine ("2) Acceleration");
			Console.WriteLine ("3) Force");
			Console.Write ("ENTER A FIGURE: ");
			string userResponse = Console.ReadLine ();

			switch (userResponse) {
			case "1":
				TwoProblem ("Velocity", 2, "speed", "seconds", "time", "seconds");
				break;
			case "2":
				TwoProblem ("Acceleration", 2, "velocity", "m/s", "time", "seconds");
				break;
			case "3":
				TwoProblem ("Force", 1, "mass", "kilograms", "acceleration", "m/s");
				break;
			case "e":
				MainMenu ();
				break;
			default:
				Console.Clear ();
				Console.WriteLine ("You didn't enter a vaild figure, please try again!");
				ContinuePrompt ();
				MainMenu ();
				break;
			}
		}

		static void ThermMenu(){
			HeaderPrompt ("Thermals");
			Console.WriteLine ("Which problem would you like to solve?");
			Console.WriteLine ("1) Entropy");
			Console.WriteLine ("2) Sensible Heat");
			Console.WriteLine ("3) Latent Heat");
			Console.Write ("ENTER A FIGURE: ");
			string userResponse = Console.ReadLine ();

			switch (userResponse) {
			case "1":
				TwoProblem ("Entropy", 3, "disorder", "k", "microstates", "w");
				break;
			case "2":
				ThreeProblem ("Sensible Heat", 2, "mass", "kilograms", "heat", "J/Kg(degrees)C", "temprature", "Celisus");
				break;
			case "3":
				TwoProblem ("Latent Heat", 1, "mass", "kilograms", "Exothermic/Endothermic phase change", "J/Kg");
				break;
			case "e":
				MainMenu ();
				break;
			default:
				Console.Clear ();
				Console.WriteLine ("You didn't enter a vaild figure, please try again!");
				ContinuePrompt ();
				MainMenu ();
				break;
			}
		}

		static void WavesOpticsMenu(){
			HeaderPrompt ("Waves and Optics");
			Console.WriteLine ("Which problem would you like to solve?");
			Console.WriteLine ("1) Periodic Waves");
			Console.WriteLine ("2) Frequency");
			Console.WriteLine ("3) Refraction");
			Console.Write ("ENTER A FIGURE: ");
			string userResponse = Console.ReadLine ();

			switch (userResponse) {
			case "1":
				TwoProblem ("Periodic Waves", 1, "frequency", "Hz", "lambda", "frequency");
				break;
			case "2":
				TwoProblem ("Frequency", 2, "1", "this line here", "time", "seconds");
				break;
			case "3":
				TwoProblem ("Refraction", 2, "power", "Joules", "Area", "");
				break;
			case "e":
				MainMenu ();
				break;
			default:
				Console.Clear ();
				Console.WriteLine ("You didn't enter a vaild figure, please try again!");
				ContinuePrompt ();
				MainMenu ();
				break;
			}
		}

		static void ElecMagMenu(){
			HeaderPrompt ("Electrcity and Magnetism");
			Console.WriteLine ("Which problem would you like to solve?");
			Console.WriteLine ("1) Ohm's Law");
			Console.WriteLine ("2) Current");
			Console.WriteLine ("3) Capacitance");
			Console.Write ("ENTER A FIGURE: ");
			string userResponse = Console.ReadLine ();

			switch (userResponse) {
			case "1":
				TwoProblem ("Ohm's Law", 1, "current", "I", "resistance", "R");
				break;
			case "2":
				TwoProblem ("Current", 2, "q", "q", "time", "seconds");
				break;
			case "3":
				TwoProblem ("Capactiance", 2, "charge separated", "Q", "potential differance", "V");
				break;
			case "e":
				MainMenu ();
				break;
			default:
				Console.Clear ();
				Console.WriteLine ("You didn't enter a vaild figure, please try again!");
				ContinuePrompt ();
				MainMenu ();
				break;
			}
		}

		static void ModernMenu(){
			HeaderPrompt("Modern and Theoretical");
			Console.WriteLine ("How am I supposed to know modern/theoretical physics?? I'm not that smart.");
			ContinuePrompt ();
			MainMenu ();
		}
		#endregion


		static void TwoProblem(string problem, int operatorx, string x, string xType, string y, string yType){
			double answer;
			HeaderPrompt (problem);
			Console.Write ($"Enter the {x} in {xType}: ");
			double xIn = double.Parse(Console.ReadLine ());
			Console.Write ($"Enter the {y} in {yType}: ");
			double yIn = double.Parse(Console.ReadLine ());

			switch (operatorx) {
			case 1:
				answer = xIn * yIn;
				Console.WriteLine ("ANSWER: " + answer);
				ContinuePrompt ();
				MainMenu ();
				break;
			case 2:
				answer = xIn / yIn;
				Console.WriteLine ("ANSWER: " + answer);
				ContinuePrompt ();
				MainMenu ();
				break;
			case 3:
				answer = xIn * Math.Log (yIn);
				Console.WriteLine ("ANSWER: " + answer);
				ContinuePrompt ();
				MainMenu ();
				break;
			default:
				Console.WriteLine ("-1: NO PROPER CASE: Drop me a line: wjmiller2016@gmail.com");
				ContinuePrompt ();
				Environment.Exit (0);
				break;
			}
		}

		static void ThreeProblem(string problem, int operatorx, string x, string xType, string y, string yType, string z, string zType){
			double answer;
			HeaderPrompt (problem);
			Console.Write ($"Enter the {x} in {xType}: ");
			double xIn = double.Parse(Console.ReadLine ());
			Console.Write ($"Enter the {y} in {yType}: ");
			double yIn = double.Parse(Console.ReadLine ());
			Console.Write ($"Enter the {z} in {zType}: ");
			double zIn = double.Parse(Console.ReadLine ());

			switch (operatorx) {
			case 1:
				answer = xIn * yIn * zIn;
				Console.WriteLine ("ANSWER: " + answer);
				ContinuePrompt ();
				MainMenu ();
				break;
			case 2:
				answer = (xIn * yIn) / zIn;
				Console.WriteLine ("ANSWER: " + answer);
				ContinuePrompt ();
				MainMenu ();
				break;
			case 3:
				answer = xIn * Math.Log (yIn);
				Console.WriteLine ("ANSWER: " + answer);
				ContinuePrompt ();
				MainMenu ();
				break;
			default:
				Console.WriteLine ("-2: NO PROPER CASE: Drop me a line: wjmiller2016@gmail.com");
				ContinuePrompt ();
				Environment.Exit (0);
				break;
			}
		}

		#region **Standard menu options**

		static void Exit(){
			Console.Clear ();
			Console.WriteLine ("\tThanks for using my application!");
			Console.WriteLine ("\tBrought to you by Wyatt J. Miller, MIT");
			Environment.Exit (0);
		}


		static void ConvertMenu(){
			Console.WriteLine ("Coming Soon(tm)!");
			ContinuePrompt ();
			MainMenu ();
		}

		static void Credits(){
			HeaderPrompt ("Credits");
			Console.WriteLine ("Miller Physics Calculator aka Copernicus v2");
			Console.WriteLine ("A poorly written physics calculator");
			Console.WriteLine ("Written and designed by Wyatt J. Miller");
			Console.WriteLine ("Copyright (c) 2017, licensed by MIT");
			Console.WriteLine ("Sources include: physics.info/eqations/");
			ContinuePrompt ();
			MainMenu ();
		}

		static void Help(){
			Console.WriteLine ("Coming Soon(tm)!");
			MainMenu ();
		}
		#endregion

		static void HeaderPrompt(string header){
			Console.Clear ();
			Console.WriteLine (header);
			Console.WriteLine ();
		}
	}
}
