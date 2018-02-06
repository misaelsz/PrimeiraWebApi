using apiCrud.bo.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiCrud.bo.negocio
{
    public class PessoaNegocio
    {
        public static List<pessoa> ListarTodos (){
            using (var context = new ApiCrudEntity())
            {
                var listaPessoasBanco = context.pessoa.ToList();
                return listaPessoasBanco;
            }
        }
    

        public static pessoa ListaPorID(Guid id)
        {
            using (var context = new ApiCrudEntity())
            {
                var pessoaBanco = context.pessoa.Where(x => x.id == id).FirstOrDefault();
                return pessoaBanco;
            }
        }

        public static pessoa ListarPorNome (String nome){
            using (var context = new ApiCrudEntity()) {
                var pessoaBanco = context.pessoa.Where(x => x.nome == nome).FirstOrDefault();
                return pessoaBanco;
            }
        }

        public static bool AddPessoa(pessoa p)
        {
            using (var context = new ApiCrudEntity()) {

                context.pessoa.Add(p);
                context.SaveChanges();
                return true;  
            }
        }

        public static void EditaPessoa(Guid id, pessoa p)
        {
            using (var context = new ApiCrudEntity())
            {
                context.Entry(p).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }

        public static bool RemovePessoa(Guid id)
        {
            using (var context = new ApiCrudEntity())
            {
                var pessoaBanco = context.pessoa.Where(x => x.id == id).FirstOrDefault();
                context.pessoa.Remove(pessoaBanco);
                context.SaveChanges();
                return true;
            }
        }
    }
}
