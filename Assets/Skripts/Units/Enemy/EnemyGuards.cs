﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TBS
{
    internal class EnemyGuards : Units
    {
        private MathOfUnits _mathOfUnits;

        internal readonly float _maxHP;
        internal readonly int _speadStep;
        internal readonly int _lengthStep;
        internal float _HP;
        internal float _DEF;
        internal float _ATK;
        internal int _nextStep;

        private void Start()
        {
            ReturnStep();
            _HP = _maxHP;
<<<<<<< Updated upstream
            _mathOfUnits = new MathOfUnits();
=======
            _listUnits = listUnits;
            _tileSpecialZone = tileSpecialZone;
        }

        public override bool SetDamage(float damage, AttackType typeAttack)
        {
            
            _HP = _mathOfUnits.MinusHP(_HP, _DEF, damage, typeAttack);
            if (_HP == 0)
            {
                Death();
            }
            return true;
>>>>>>> Stashed changes
        }

        public override int GetLenghtStep() => _lengthStep;
        public override int GetNextStep() => _nextStep;
        public override void MinusStep() => _nextStep = _mathOfUnits.MinusOneStep(_nextStep);
        public override void ReturnStep() => _nextStep = _speadStep;
        public override float GetHP() => _HP;
        public override float GetATK() => _ATK;
        public override Vector3 GetPosition() => transform.position;
        public override void SetPosition(Vector3 newpos) => transform.position = newpos;
    }
}

