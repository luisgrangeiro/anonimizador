using Core;
using System.Collections.Generic;

namespace Infra
{
    public class ClubRepository
    {
        public List<ClubRegister> GetClubRegisters()
        {
            return ClubDataBase.Data;
        }
    }
}
