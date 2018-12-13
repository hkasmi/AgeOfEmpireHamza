using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AOE.BLL.UseCases;
using AOE.BLL.MessagesBTO;

namespace AOE.BLL.UseCases.PlayerTests
{
    [TestClass]
    public class CreerBatimentTests
    {
        [TestMethod]
        public void CreerBatiment()
        {
            //Arrange
            //var MessageCreeBatiment = new Msg("Farm");
            var player = new PlayerUC();
            var OrdreDeConstruction = new CreationBatiment
            {
                TypeBatiment = TypeBatiment.Maison,
                X = 1,
                Y = 10
            };

            //Act
            var Result = player.CreerBatiment(OrdreDeConstruction);

            //ASssert
            Assert.IsTrue(Result);
        }
    }
}
