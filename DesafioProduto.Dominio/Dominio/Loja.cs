using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesafioProduto.Dominio.Dominio
{
    [Table("tb_Loja")]
    public class Loja
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public ItemEstoque ItemEstoque { get; set; }

        [ForeignKey("ItemEstoque")]
        public int Id_ItemEstoque { get; set; }
    }
}
