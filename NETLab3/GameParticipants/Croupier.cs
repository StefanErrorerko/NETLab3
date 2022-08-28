using System;
using System.Collections.Generic;
using NETLab3.GameItems;
namespace NETLab3.GameParticipants
{
    internal class Croupier
    {
        public GameBoard Board { get; }
        public List<Chip> Chips { get; }
        private static Croupier? _instance;
        private Croupier(int boardSize, int chip10Amount, int chip50Amount, int chip100Amount) 
        {
            Board = new GameBoard(boardSize);
            Chips = new List<Chip>();
            for (int i = 0; i < chip10Amount; i++)
            {
                Chips.Add(new Chip10());
            }
            for (int i = 0; i < chip50Amount; i++) 
            { 
                Chips.Add(new Chip50()); 
            }
            for (int i = 0; i < chip100Amount; i++)
            {
                Chips.Add(new Chip100());
            }

        }
        public static Croupier GetInstance(
            int boardSize, 
            int chip10Amount, 
            int chip50Amount, 
            int chip100Amount)
        {
            if (_instance == null)
            {
                _instance = new Croupier(boardSize, chip10Amount, chip50Amount, chip100Amount);
            }
            return _instance;
        }
    }
}
