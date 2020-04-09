using System.Collections.Generic;
using System.Linq;
using DevSquad.Exceptions;
using Xunit;

namespace DevSquad.Test
{
    public class DeveloperSquadTest
    {
        private static ISquadManager NovaInstancia()
        {
            return new SquadManager();
        }

        private static ISquadManager AdicionarSquad(long squadId)
        {
            var manager = NovaInstancia();

            manager.AddSquad(squadId, $"Squad {squadId}");

            return manager;
        }

        private static ISquadManager AdicionarDesenvolvedorEmSquad(long squadId, long developerId)
        {
            var manager = AdicionarSquad(squadId);
            
            manager.AddDev(developerId, squadId, $"Desenvolvedor {developerId}");

            return manager;
        }

        private static ISquadManager AdicionarDesenvolvedoresEmSquad(long squadId, IEnumerable<long>developersIds)
        {
            var manager = AdicionarSquad(squadId);

            developersIds
                .ToList()
                .ForEach(playerId =>
                {
                    manager.AddDev(playerId, squadId, $"Desenvolvedor {playerId}");
                });

            return manager;
        }

        [Fact]
        public void Nao_Devera_Achar_Developer()
        {
            //arranje - definir entrada
            long devIdErrado = 2;

            //act - método a ser testado
            var manager = NovaInstancia();

            //assert - resultado
            Assert.Throws<SquadNotFoundException>(() => manager.GetSquadName(devIdErrado));
        }

        [Fact]
        public void Nao_Devera_Achar_Squad()
        {
            //arranje - definir entrada
            long squadIdErrado = 2;

            //act - método a ser testado
            var manager = NovaInstancia();

            //assert - resultado
            Assert.Throws<SquadNotFoundException>(() => manager.GetSquadName(squadIdErrado));
        }

        [Fact]
        public void Adicionar_e_Achar_Squad()
        {
            //arranje - definir entrada
            long squadId = 1;
            long squadIdErrado = 2;

            //act - método a ser testado
            var manager = AdicionarSquad(squadId);

            //assert - resultado
            Assert.Throws<SquadNotFoundException>(() => manager.GetSquadName(squadIdErrado));
            Assert.Equal($"Squad {squadId}", manager.GetSquadName(squadId));
        }

        [Fact]
        public void Adicionar_e_Achar_Desenvolvedor()
        {
            //arranje - definir entrada
            long squadId = 1;
            long devId = 1;
            long squadIdErrado = 2;

            //act - método a ser testado
            var manager = AdicionarDesenvolvedorEmSquad(squadId, devId);

            //assert - resultado
            Assert.Throws<SquadNotFoundException>(() => manager.GetSquadDevs(squadIdErrado));
            Assert.Equal($"Desenvolvedor {devId}", manager.GetDevName(devId));
        }

        [Fact]
        public void Nao_Devera_Achar_Tech_Leader()
        {
            //arranje - definir entradar
            long squadId = 1;
            long devId = 1;

            //act - método a ser testado
            var manager = AdicionarDesenvolvedorEmSquad(squadId, devId);

            //assert - resultado
            Assert.Throws<TechLeaderNotFoundException>(() => manager.GetSquadTechLeader(squadId));
        }

        [Fact]
        public void Adicionar_e_Achar_Tech_Leader()
        {
            //arranje - definir entrada
            long squadId = 1;
            long devId = 1;
            long techLeaderId = 1;

            //act - método a ser testado
            var manager = AdicionarDesenvolvedorEmSquad(squadId, devId);

            //assert - resultado
            Assert.Throws<TechLeaderNotFoundException>(() => manager.GetSquadTechLeader(squadId));

            manager.SetTechLeader(techLeaderId);
            Assert.Equal(techLeaderId, manager.GetSquadTechLeader(squadId));
        }

        [Fact]
        public void Devera_garantir_Lista_Devs_Orddenada()
        {
            //arranje - definir entrada
            long squadId = 1;
            var devsIds = new List<long>() { 15, 2, 33, 4, 13 };

            //act - método a ser testado
            var manager = AdicionarDesenvolvedoresEmSquad(squadId, devsIds);
            devsIds.Sort();

            //assert - resultado
            Assert.Equal(devsIds, manager.GetSquadDevs(squadId));
        }

        [Theory]
        [InlineData("15; 2; 33; 4; 13")]
        public void Devera_Garantir_Lista_Devs_Ordenada_Args(string devs)
        {
            //arranje - definir entrada
            long squadId = 1;

            var devsIds = devs.Split(';').Select(x => long.Parse(x)).ToList();

            //act - método a ser testado
            var manager = AdicionarDesenvolvedoresEmSquad(squadId, devsIds);
            devsIds.Sort();

            //assert - resultado
            Assert.Equal(devsIds, manager.GetSquadDevs(squadId));
        }
    }
}
