using System;
using System.Collections.Generic;
using System.Text;

namespace AOE.model
{
    public class Stats
    {
        private int _life_point;
        private int _attack;
        private int _defence;
        private int _speed;
        private int _range;

        public Stats(int LifePoint, int Attack, int Defence, int Speed, int Range)
        {
            _life_point = LifePoint;
            _attack = Attack;
            _defence = Defence;
            _speed = Speed;
            _range = Range;
        }

        public int Lifepoint
        {
            get { return _life_point; }
            set { _life_point = value; }
        }

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int Range
        {
            get { return _range; }
            set { _range = value; }
        }

        public void dammaged(int attaqueEnnemie) {
            this._life_point -= attaqueEnnemie - _defence > 0 ? (attaqueEnnemie - _defence) : 1;
        }

        public static Stats operator +(Stats first, Stats second)
        {
            return new Stats(first.Lifepoint + second.Lifepoint, first.Attack + second.Attack, first.Defence + second.Defence, first.Speed + second.Speed, first.Range + second.Range);
        }
        public static Stats operator -(Stats first, Stats second)
        {
            return new Stats(first.Lifepoint - second.Lifepoint, first.Attack - second.Attack, first.Defence - second.Defence, first.Speed - second.Speed, first.Range - second.Range);
        }

    }
}
