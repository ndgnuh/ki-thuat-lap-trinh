using System;
using System.Collections.Generic;

namespace KnightsTour 
{
	class Program 
	{
		/* width and height of the board */
		static public int width  = 5;
		public static int height = 5;

		/*
		 * width and height, with setinel value
		 * row i, col j -> i * m +  j
		 */
		public static int n = height + 4;
		public static int m = width + 4;

		public static int startPos = 3*m + 4;
		public static int solutionsCount = 0;

		/* set if we must find closed solutions or not */
		public static bool forceClosed = true;
		
		/* find 1 or more solution */
		public static bool findOnce = false;

		/* track the level of back tracking */
		public static int trackLevel = 0;

		/*
		 * indicates if a spot can be jumped to
		 * -1 can be jumped to
		 * -2 cannot be jumpted to
		 * n: has been jumped to in the nth step
		 */
		public static List<int> Path = new List<int> {};

		public static void Main(){
			int startx = 0;
			int starty = 0;
			Prepare();
			Try((starty + 3) * m + startx + 4);
			Console.WriteLine("Total numer of solutions: " + solutionsCount);
		}

		/* prepare the board */
		public static void Prepare(){
			for(int i = 0; i < n*m; i++) {
				Path.Add(-1);
			}

			/* sentinel border cannot be moved to */
			for(int i = 0; i < n; i++) {
				Path[i*m+1  ] = -2;
				Path[i*m    ] = -2;
				Path[i*m+m-1] = -2;
				Path[i*m+m-2] = -2;
			}
			for(int j = 2; j < m-2; j++) {
				Path[j        ] = -2;
				Path[m+j      ] = -2;
				Path[m*n-1-j  ] = -2;
				Path[m*n-m-1-j] = -2;
			}
		}

		public static bool Try(int i) {
			if(Path[i] == width*height-1){
				solutionsCount+=1;
				PrintBoard();
			}
			if(findOnce && solutionsCount > 0) return false;
			List<int> moves = new List<int> {
				  i -   m - 2, 
				  i -   m + 2,
				  i +   m - 2,
				  i +   m + 2,
				  i - 2*m - 1,
				  i - 2*m + 1,
				  i + 2*m - 1,
				  i + 2*m + 1
			};
			foreach(int j in moves) {
				if(Path[j] == -1) { 
					Path[j] = Path[i]+1;
					Try(j);
					Path[j] = -1;
				}
			}
		return true;
	}

		public static void PrintBoard(bool all = false){
			for(int i = 0; i < m; i++) Console.Write("###");
			Console.WriteLine("");

			int start = all ? 0 : 2;
			int end = all ? n : n -2;
			int cend = all ? m : m -2;

			for(int i = start; i < end; i++) {
				for(int j = start; j < cend; j++)
					if (Path[i*m+j] == -1) Console.Write("|   ");
					else Console.Write("|" + Convert.ToString(Path[i*m+j]).PadLeft(3));
				Console.WriteLine("|");
			}
		}
	}

}

