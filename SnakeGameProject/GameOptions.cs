using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameProject
{
    public enum GameBoardSize { small, medium, large }
    public enum GameDifficulty { easy, medium, hard }
    public class GameOptions
    {
       
        
        //Properties
        public GameBoardSize BoardSize { get; set; }

        public GameDifficulty Difficulty { get; set; }
        public int BoardWidth 
        { 
            get
            { 
                
                return GetBoardWidth(BoardSize); 
            } 
        }      
        
        public int BoardHeight 
        {
            get
            {
                return GetBoardHeight(BoardSize);
            } 
        }
        //Methods
        private int GetBoardHeight(GameBoardSize gameBoardSize)
        {
            int value = 0;
            switch (gameBoardSize)
            {
                case GameBoardSize.small:
                    value = 18;
                    return value;
                case GameBoardSize.medium:
                    value = 21;
                    return value;
                case GameBoardSize.large:
                    value = 25;
                    return value;
                default:
                    value = 18;
                    return value;
            }
        }

        

        public int GetBoardWidth(GameBoardSize gameBoardSize) 
        {
            int value = 0;
            switch (gameBoardSize)
            {                
                case GameBoardSize.small:
                    value = 30;
                    return value;
                case GameBoardSize.medium:
                    value = 40;
                    return value;
                case GameBoardSize.large:
                    value = 50;
                    return value;
                default:
                    value = 30;
                    return value;
            }


        }
        public GameOptions()
        {

        }
        public GameOptions(GameBoardSize boardSize, GameDifficulty difficulty)
        {
            BoardSize = boardSize;
            Difficulty = difficulty;
            
        }
        //private void playSimpleSound()
        //{
        //    SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows");
        //    simpleSound.Play();
        //}











        //   string [,] userHighScores = new string[5,2] { { "Terrible Player" = 1, 32 } { "Not Really Trying", 14 } { "Sleepy", 9 } { "Unkind Adjective", 11 } //{ "Bored", 27 } };
        //public int UpdateUserHighScore (string userName, int userScore)
        //{
        //    //when game ends userscore will loop through and see if it's higher than any of the other scores. 
        //    //if it is, then the score will be updated, the username at the same index will be updated in the other array,
        //    //and the menu will be updated
        //    //foreach ( string userScore in userHighScore)
        //    //{
        //    //    Array.Sort(userHighScores);
        //    //    foreach (string i in userHighScores)
        //    //    {
        //    //        int indexOne = userHighScores[1, 2];
        //    //        int indexTwo = userHighScores[2, 2];
        //    //        int indexThree = userHighScores[3, 2];
        //    //        int indexFour = userHighScores[4, 2];
        //    //        int indexFive = userHighScores[5, 2];
        //    //    }
        //    //    if (newUserScore > userHighScores.Min())   
        //    //    {


        //    //    }
        //    return 0;
        //    }
        //}

    }   
}
