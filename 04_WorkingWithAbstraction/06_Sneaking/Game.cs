using System;
using System.Collections.Generic;

namespace _06_Sneaking
{
    class Game
    {
        private List<char[]> room = new List<char[]>();
        private List<Coordinates> enemies = new List<Coordinates>();
        public Coordinates Nikoladze { get; private set; }
        public Coordinates Sam { get; private set; }

        private void MakeEnemiesMoves()
        {
            foreach (var enemy in enemies)
            {
                char enemyDirection = room[enemy.i][enemy.j];
                room[enemy.i][enemy.j] = '.';

                if (enemy.j == room[enemy.i].Length - 1 || enemy.j == 0)
                    ChangeEnemyDirection(enemy, enemyDirection);
                else
                    EnemyMoveStraight(enemy, enemyDirection);
            }
        }

        private void EnemyMoveStraight(Coordinates enemy, char direction)
        {
            switch (direction)
            {
                case 'b':
                    room[enemy.i][++enemy.j] = 'b';
                    break;
                case 'd':
                    room[enemy.i][--enemy.j] = 'd';
                    break;
            }
        }

        private void ChangeEnemyDirection(Coordinates enemy, char direction)
        {
            room[enemy.i][enemy.j] = (direction == 'd') ? 'b' : 'd';
        }

        private void EnemiesTryKillSam()
        {
            foreach (var enemy in enemies)
                if ((enemy.i == Sam.i && room[enemy.i][enemy.j].Equals('b') && enemy.j < Sam.j) ||
                    (enemy.i == Sam.i && room[enemy.i][enemy.j].Equals('d') && enemy.j > Sam.j))
                {
                    room[Sam.i][Sam.j] = 'X';
                }
        }

        public void MakeSamMove(char direction)
        {
            MakeEnemiesMoves();
            EnemiesTryKillSam();

            if (direction.Equals('W') || IsCharacterDead(Sam))
                return;

            room[Sam.i][Sam.j] = '.';
            switch (direction)
            {
                case 'U':
                    room[--Sam.i][Sam.j] = 'S';
                    break;
                case 'D':
                    room[++Sam.i][Sam.j] = 'S';
                    break;
                case 'L':
                    room[Sam.i][--Sam.j] = 'S';
                    break;
                case 'R':
                    room[Sam.i][++Sam.j] = 'S';
                    break;
            }

            if (Sam.i == Nikoladze.i)
                room[Nikoladze.i][Nikoladze.j] = 'X';
        }

        public bool IsCharacterDead(Coordinates character)
        {
            return room[character.i][character.j] == 'X';
        }

        public void PrintRoom()
        {
            foreach (var row in room)
                Console.WriteLine(row);
        }

        public void AddRow(char[] row)
        {
            room.Add(row);
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] == 'N')
                    Nikoladze = new Coordinates(room.Count - 1, i);
                else if (row[i] == 'S')
                    Sam = new Coordinates(room.Count - 1, i);
                else if (row[i] == 'b' || row[i] == 'd')
                    enemies.Add(new Coordinates(room.Count - 1, i));
            }
        }
    }
}
