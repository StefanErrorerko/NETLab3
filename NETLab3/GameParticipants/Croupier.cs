using System;
using System.Collections.Generic;
using NETLab3.GameItems;
namespace NETLab3.GameParticipants
{
    internal class Croupier
    {
        public GameBoard Board { get; }
        public List<Chip> Chips { get; }
        private static Croupier _instance;
        private Croupier(int boardsize, int chip10, int chip50, int chip100) 
        {
            Board = new GameBoard(boardsize);
            Chips = new List<Chip>();
            for (int i=0; i<chip10; i++) Chips.Add(new Chip10());
            for (int i = 0; i < chip50; i++) Chips.Add(new Chip50());
            for (int i = 0; i < chip100; i++) Chips.Add(new Chip100());

        }
        public static Croupier GetInstance(int boardsize, int chip10, int chip50, int chip100)
        {
            if (_instance == null)
            {
                _instance = new Croupier(boardsize, chip10, chip50, chip100);
            }
            return _instance;
        }
    }
}
