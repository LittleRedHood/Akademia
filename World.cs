using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleRedHood
{
    class World
    {
        private int __coordX { set; get; }
        private int __coordY { set; get; }
        private List<int> __objects { set; get; } = new List<int>(); //zmienić typ na klasę obiektów // nie wiem, czy set i get w tym miejcu nie 
        //będzie wywalać błędów; teoretycznie nie powinien 
        private int __player;//zmienić typ na klasę obiektów

        public World(int x, int y, int player)
        {
            __coordX = x;
            __coordY = y;
            __player = player;
        }
        public void AddObject(int item) // zmienić typ na klasę obiekt
        {
            __objects.Add(item);
        } 
        public void RemoveObject(int item)
        {
            __objects.Remove(item);
        }
        public void DrawWorld() { } // funkcja rysująca cały świat - w jej środku rysowanie poszczególnych elementów z listy objects
        public void Collision() { } // sprawdzanie kolizji całego świata (?)
        public void NewGame() { } // wydaje mi się, że powinno to być w tej klasie
        public void Save() { }
        public void Load() { }
        public void ShowHighScore() { } //wyświetlenie rankingu punktów
        public void NewRound() { } // implementacja całej nowej tury (nie wiem, czy jest tutaj potrzebne)
        public void End() { } //co się dzieje, kiedy skończy się gra
    }
}
