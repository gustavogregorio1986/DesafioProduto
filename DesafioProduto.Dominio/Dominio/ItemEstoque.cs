using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesafioProduto.Dominio.Dominio
{
    [Table("tb_ItemEstoque")]
    public class ItemEstoque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Qtde { get; set; }

        public Produto Produto { get; set; }

        [ForeignKey("Produto")]
        public int Id_Produto { get; set; }
    }
}
