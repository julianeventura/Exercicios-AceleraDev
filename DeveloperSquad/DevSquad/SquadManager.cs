using System.Collections.Generic;
using System.Linq;
using DevSquad.Exceptions;

namespace DevSquad
{
    public class SquadManager : ISquadManager
    {
        private Dictionary<long, Squad> squads;
        private Dictionary<long, Developer> devs;

        public SquadManager()
        {
            squads = new Dictionary<long, Squad>();
            devs = new Dictionary<long, Developer>();
        }

        private Developer GetDev(long devId)
        {
            Developer dev;

            if (!devs.TryGetValue(devId, out dev))
            {
                //lançar uma exceção do tipo DeveloperNotFound
                throw new DevNotFoundException();
            }

            return dev;
        }

        private Squad GetSquad(long squadId)
        {
            Squad squad;

            if (!squads.TryGetValue(squadId, out squad))
            {
                //lançar uma exceção do tipo SquadNotFound
                throw new SquadNotFoundException();
            }

            return squad;
        }

        public string GetDevName(long devId)
        {
            Developer dev = GetDev(devId);

            return dev.Name;
        }

        public string GetSquadName(long squadId)
        {
            Squad squad = GetSquad(squadId);

            return squad.Name;
        }

        public void AddSquad(long id, string name)
        {
            if (squads.ContainsKey(id))
            {
                throw new UniqueIdentifierException();
            }

            var squad = new Squad()
            {
                Id = id,
                Name = name
            };

            squads.Add(id, squad);
        }

        public void AddDev(long id, long squadId, string name)
        {
            if (devs.ContainsKey(id))
            {
                throw new UniqueIdentifierException();
            }

            Squad squad = GetSquad(squadId);

            var dev = new Developer()
            {
                Id = id,
                SquadId = squadId,
                Name = name
            };

            devs.Add(id, dev);
        }

        public void SetTechLeader(long devId)
        {
            Developer dev = GetDev(devId);

            squads[dev.SquadId].TechLeaderId = devId;
        }
        
        public long GetSquadTechLeader(long squadId)
        {
            Squad squad = GetSquad(squadId);

            if(!squad.TechLeaderId.HasValue)
            {
                throw new TechLeaderNotFoundException();
            }

            return squad.TechLeaderId.Value;
        }

        private IEnumerable<Developer> GetDevsOnSquad(long squadId)
        {
            return devs.Values.Where(x => x.SquadId == squadId);
        }

        public List<long> GetSquadDevs(long squadId)
        {
            Squad squad = GetSquad(squadId);

            return GetDevsOnSquad(squadId)
                .Select(x => x.Id)
                .OrderBy(x => x)
                .ToList();
        }
    }
}
