using System.Collections.Generic;

namespace DevSquad
{
    public interface ISquadManager
    {
        string GetDevName(long devId);
        string GetSquadName(long squadId);
        void AddSquad(long id, string name);
        void AddDev(long id, long squadId, string name);
        void SetTechLeader(long devId);
        long GetSquadTechLeader(long squadId);
        List<long> GetSquadDevs(long squadId);
    }
}