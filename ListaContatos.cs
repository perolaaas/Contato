using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Contato1
{
    class ListaContatos
    {

        public List<Contato> lContatos = new List<Contato>();

        public int listCount()
        {
            return lContatos.Count;
        }

        public void incluir(Contato c)
        {
            lContatos.Add(c);
        }//incluir()

        public bool alterar(Contato c)
        {
            int opcao = lContatos.IndexOf(c);
            bool achou;

            achou = (opcao >= 0);
            if (achou)
            {
                lContatos.RemoveAt(opcao);
                lContatos.Insert(opcao, c);
            }
            return achou;
        }//alterar

        public bool excluir(Contato c)
        {
            return lContatos.Remove(c);
        }//excluir

       public Contato pesquisar(Contato c)
        {
            int opcao = lContatos.IndexOf(c);
            return lContatos[opcao];
        }//pesquisar

        public bool validar(Contato c)
        {
            int opcao = lContatos.FindIndex(x => x == c);
            if(opcao == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//validar
        

    }//class
}//namespace
