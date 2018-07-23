using Microsoft.VisualStudio.TestTools.UnitTesting;
using TJMT.Prova.Senior.Domain.Entities;

namespace TMT.Prova.Senior.Domain.Tests
{
    [TestClass]
    public class LivroTest
    {
        private int _quantidadePagina_Invalida = -1;
        private int _quantidadePagina_Valida = 1;
        private Livro _livro;

        public LivroTest()
        {
            _livro = new Livro()
            {
                Paginas = 1
             };
        }

        [TestMethod]
        public void Quando_criar_livro_com_quantidade_Paginas_invalida()
        {
            Assert.AreEqual(_quantidadePagina_Invalida > 0, _livro.IsQtdePaginaValida);
        }

        [TestMethod]
        public void Quando_criar_livro_com_quantidade_Paginas_valida()
        {
            Assert.AreEqual(_quantidadePagina_Valida > 0, _livro.IsQtdePaginaValida);
        }
    }
}
