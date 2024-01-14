using Player;
using UnityEngine;

namespace Enemy
{
    public class PlayerDiedTransition : BossTransition
    {
        [SerializeField] private PlayerHealth _player;

        private void Update()
        {
            if (_player.IsDead)
            {
                NeedTransit = true;
            }
        }
    }
}